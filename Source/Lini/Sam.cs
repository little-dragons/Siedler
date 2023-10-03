using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Graph;
using Lini.Windowing;

namespace Lini;

public static class Sam
{
    private static GLFW.WindowRef WindowRef { get; set; }
    public static bool IsInitialized { get; private set; }
    public static readonly Version Version = new(0, 0, 1);

    public static bool Initialize(WindowInfo winInfo)
    {
        if (IsInitialized)
            return IsInitialized;

        Logger.Info($"Initializing Lini engine {Version}. Hi!", Logger.Source.MainThread);

        Resources.Initialize();


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

        GLFW.WindowHint(GLFW.WindowHintType.ClientApi, GLFW.WindowValue.OpenGLAPI);
        GLFW.WindowHint(GLFW.WindowHintType.OpenGLProfile, GLFW.WindowValue.OpenGLCoreProfile);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMajor, 4);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMinor, 0);
        GLFW.WindowHint(GLFW.WindowHintType.Samples, 4);

        WindowRef = GLFW.CreateWindow(winInfo.Width, winInfo.Height, winInfo.Title, winInfo.FullScreen ? GLFW.GetPrimaryMonitor() : GLFW.MonitorRef.Null, 0);
        if (WindowRef.Raw == 0)
        {
            Logger.Error("Could not make window, aborting.", Logger.Source.GLFW);
            return IsInitialized;
        }


        Thread.CurrentThread.Name = "MainThread";
        RenderThread.Initialize();

        RenderThread.Do(() =>
        {
            GLFW.MakeContextCurrent(WindowRef);
            GLFW.SwapInterval(true);
            GL.Load(GLFW.GetProcAddress);


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

        while (!GLFW.WindowShouldClose(WindowRef))
        {
            GLFW.PollEvents();
            
            RenderThread.Do(() => GL.Clear(ClearBufferMask.Color));
            RenderThread.Do(() => scene.Render(new RenderArgs(SharedObjects.SimpleProgram, 24)));

            RenderThread.Finish();

            RenderThread.Do(() => GLFW.SwapBuffers(WindowRef));
        }

        Logger.Info("Exiting main loop.", Logger.Source.MainThread);
    }
}
