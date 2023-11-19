using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Graph;
using Lini.Windowing;
using Lini.Graph.Components;

namespace Lini;

public static class Sam
{
    public static Window Window { get; private set; } = null!;
    public static bool IsInitialized { get; private set; } = false;
    public static Version Version => new(0, 0, 1);

    public static bool Initialize(WindowInfo winInfo)
    {
        if (IsInitialized)
            return IsInitialized;

        Logger.Info($"Initializing Lini engine {Version}. Hi!", Logger.Source.MainThread);

        Resources.Initialize();
        ComponentReflection.Initialize(AppDomain.CurrentDomain.GetAssemblies());

        Thread.CurrentThread.Name = "MainThread";
        RenderThread.Initialize();

        Logger.Info($"Using version {GLFW.GetVersion()}.", Logger.Source.GLFW);

        if (!GLFW.Init())
        {
            Logger.Info("GLFW failed to initialize, aborting.", Logger.Source.GLFW);
            return IsInitialized;
        }


        GLFW.SetErrorCallback((ec, str) =>
        {
            Logger.Error($"{ec} - {str}", Logger.Source.GLFWCallback);
        });

        if (!Window.TryMake(winInfo, out Window? w))
        {
            Logger.Error("Could not make window, aborting.", Logger.Source.GLFW);
            return IsInitialized;
        }
        Window = w;
        


        RenderThread.Do(() =>
        {
            GL.DebugProc callback = (s, t, id, sev, message) =>
            {
                Logger.Level level = sev switch
                {
                    DebugSeverity.High => Logger.Level.Error,
                    DebugSeverity.Medium or DebugSeverity.Low => Logger.Level.Warning,
                    _ => Logger.Level.Info
                };

                Logger.Write(level, $"ID {id}. {message}", Logger.Source.GLCallback);
            };


            GL.Enable(EnableCap.DebugOutput);

            GL.DebugMessageCallback(callback);
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

    public static void Terminate()
    {
        if (!IsInitialized)
            return;

        Logger.Info("Terminating.", Logger.Source.MainThread);
        SharedObjects.Terminate();
        ComponentReflection.Terminate();

        // GLFW termination requires that a context is only current on the main thread.
        RenderThread.Do(() => GLFW.MakeContextCurrent(GLFW.WindowRef.Null));
        RenderThread.FinishAndTerminate();

        GLFW.Terminate();

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

            UpdateArgs args = new(0.16f, Window.Input);
            scene.UpdateAll(args);

            RenderThread.Do(() => GL.Clear(ClearBufferMask.Color));
            RenderThread.Do(() => scene.Render(new RenderArgs(SharedObjects.SimpleProgram, 24)));

            Window.FinishFrame();

            RenderThread.Finish();
        }

        Logger.Info("Exiting main loop.", Logger.Source.MainThread);
    }
}
