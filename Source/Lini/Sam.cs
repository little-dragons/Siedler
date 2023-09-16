using System.Runtime.InteropServices;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing;

namespace Lini;

public static class Sam
{
    public static GLFW.WindowRef WindowRef { get; private set; }
    public static bool IsInitialized { get; private set; }

    public static bool Initialize(WindowInfo winInfo)
    {
        if (IsInitialized)
            return IsInitialized;

        Logger.Info("Initializing...", Logger.Source.Control);

        GLFW.GetVersion(out int major, out int minor, out int rev);
        Version glfwVersion = new(major, minor, rev);

        Logger.Info($"Using version {glfwVersion}.", Logger.Source.GLFW);

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
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMajor, (GLFW.WindowValue)4);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMinor, (GLFW.WindowValue)0);

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
            GL.Load(GLFW.GetProcAddress);


            GL.DebugProc callback = (s, t, id, sev, message) =>
            {
                Logger.Level level = sev switch
                {
                    DebugSeverity.High => Logger.Level.Error,
                    DebugSeverity.Medium or DebugSeverity.Low => Logger.Level.Warning,
                    _ => Logger.Level.Info
                };

                Logger.Write(level, message, Logger.Source.GLCallback);
            };

            GL.Enable(EnableCap.DebugOutput);

            GL.DebugMessageCallback(callback);
            GL.DebugMessageInsert(DebugSource.Application, DebugType.Marker, 0, DebugSeverity.Notification, "Test message injected.");

            GL.ClearColor(1.0f, 0.5f, 0.2f, 1.0f);

            string vertexShaderSource =
                """
                #version 330

                layout(location = 0) in vec3 coord;
                void main() {
                    gl_Position = vec4(coord, 1.0);
                }
                """;

            string fragmentShaderSource =
                """
                #version 330

                out vec4 color;
                void main() {
                    color = vec4(1.0);
                }
                """;


            var prog = GL.CreateProgram();
            var vertexShader = GL.CreateShader(ShaderType.Vertex);
            var fragmentShader = GL.CreateShader(ShaderType.Fragment);
            GL.ShaderSource(vertexShader, vertexShaderSource);
            GL.ShaderSource(fragmentShader, fragmentShaderSource);

            GL.CompileShader(vertexShader);
            GL.CompileShader(fragmentShader);

            GL.AttachShader(prog, vertexShader);
            GL.AttachShader(prog, fragmentShader);

            GL.LinkProgram(prog);
            GL.UseProgram(prog);
        });

        RenderThread.Finish();

        IsInitialized = true;
        return IsInitialized;
    }

    public static void Terminate()
    {
        if (!IsInitialized)
            return;

        // GLFW terminatino requires that a context is only current on the main thread.
        RenderThread.Do(() => GLFW.MakeContextCurrent(new GLFW.WindowRef()));
        RenderThread.FinishAndTerminate();

        GLFW.Terminate();

        IsInitialized = true;
        Logger.Info("Terminated.", Logger.Source.Control);
    }

    public static void Run(Mesh mesh)
    {
        if (!IsInitialized)
            return;

        Logger.Info("Running main loop...", Logger.Source.Control);

        while (!GLFW.WindowShouldClose(WindowRef))
        {
            RenderThread.Do(() => GL.Clear(ClearBufferMask.Color));

            mesh.Draw();

            RenderThread.Finish();

            GLFW.PollEvents();
            RenderThread.Do(() => GLFW.SwapBuffers(WindowRef));
        }
    }
}
