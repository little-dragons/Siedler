using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Graph;
using Lini.Windowing;
using Lini.Graph.Components;

namespace Lini;

/// <summary>
/// The main class through which the Lini engine may be accessed. Before any components from the Lini engine may be accessed,
/// the engine must be initialized through <see cref="Initialize"/>. The only exceptions are <see cref="Version"/> and 
/// <see cref="IsInitialized"/>.
/// </summary>
public static class Sam
{
    /// <summary>
    /// Currently, the Lini engine only supports a single window.
    /// </summary>
    private static Window Window { get; set; } = null!;

    /// <summary>
    /// The value whether the engine is currently initialized.
    /// </summary>
    public static bool IsInitialized { get; private set; } = false;

    /// <summary>
    /// The version of the Lini engine.
    /// </summary>
    public static Version Version => new(0, 0, 1);

    /// <summary>
    /// This method initializes the engine. Currently, it also creates an empty window according to the given information.
    /// </summary>
    /// <param name="winInfo">The information with which the first window may be created.</param>
    /// <returns>Whether the engine could be successfully initialized.</returns>
    public static bool Initialize(WindowInfo winInfo)
    {
        if (IsInitialized)
            return true;

        Logger.Info($"Initializing Lini engine {Version}. Hi!", Logger.Source.MainThread);

        Resources.Initialize();
        ComponentReflection.Initialize(AppDomain.CurrentDomain.GetAssemblies());

        Thread.CurrentThread.Name = "MainThread";
        RenderThread.Initialize();

        // here starts the part which might really lead to a crash - the rest is pretty much contained in the library
        // from here on, we rely on external assumptions, e.g. that OpenGL and GLFW are correctly supported.

        if (!Window.Manager.Initialize())
            return false;

        if (!Window.Manager.TryMake(winInfo, out Window? w))
        {
            Logger.Error("Could not make window, aborting.", Logger.Source.GLFW);
            return false;
        }
        Window = w;



        RenderThread.Do(() =>
        {
            // making this a local function prevents garbage collection
            static void GLCallback(DebugSource s, DebugType t, uint id, DebugSeverity sev, string message)
            {
                Logger.Level level = sev switch
                {
                    DebugSeverity.High => Logger.Level.Error,
                    DebugSeverity.Medium or DebugSeverity.Low => Logger.Level.Warning,
                    _ => Logger.Level.Info
                };

                Logger.Write(level, $"ID {id}. {message}", Logger.Source.GLCallback);
            }


            GL.Enable(EnableCap.DebugOutput);

            GL.DebugMessageCallback(GLCallback);
            GL.DebugMessageInsert(DebugSource.Application, DebugType.Marker, 0, DebugSeverity.Notification, "Test message injected.");
            GL.Enable(EnableCap.Multisample);
            GL.ClearColor(1.0f, 0.5f, 0.2f, 1.0f);

            SharedObjects.Initialize();
            SharedObjects.SimpleProgram.Bind();
        });

        RenderThread.Finish();

        Logger.Info("Initializing done.", Logger.Source.MainThread);

        IsInitialized = true;
        return IsInitialized;
    }

    /// <summary>
    /// This method terminates the engine and does cleanup. This function may even be called when initialization is not successful. 
    /// It might produce warnings because some parts which never have been initialized will be cleanuped but the function will always succeed.
    /// </summary>
    public static void Terminate()
    {
        Logger.Info("Terminating.", Logger.Source.MainThread);
        SharedObjects.Terminate();
        ComponentReflection.Terminate();

        if (Window is not null)
        {
            Window.Manager.Kill(Window);
            Window = null!;
        }

        Window.Manager.Terminate();

        RenderThread.FinishAndTerminate();

        IsInitialized = false;
        Logger.Info("Exiting Lini engine. Goodbye.", Logger.Source.MainThread);
    }

    public static void Run(Scene scene)
    {
        if (!IsInitialized)
            return;

        var time = DateTime.Now.Ticks;


        Logger.Info("Starting main loop.", Logger.Source.MainThread);

        while (!Window.ReceivedCloseMessage())
        {
            GLFW.PollEvents();

            UpdateArgs args = new(0.16f, Window.Input)
            {
                WindowInfo = Window.Info
            };
            scene.UpdateAll(args);
            Window.Apply(args.WindowInfo);

            RenderThread.Do(() => GL.Clear(ClearBufferMask.Color));
            RenderThread.Do(() => scene.Render(new RenderArgs(SharedObjects.SimpleProgram, 24)));

            Window.FinishFrame();

            RenderThread.Finish();
        }

        Logger.Info("Exiting main loop.", Logger.Source.MainThread);
    }
}
