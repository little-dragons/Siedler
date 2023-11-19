using System.Diagnostics.CodeAnalysis;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing.Input;

namespace Lini.Windowing;

public class Window
{
    // private Vector2 LastWindowSize;
    // private Vector2 LastWindowPos;

    private GLFW.WindowRef Ref { get; init; }
    internal GLFWInputWrapper Input { get; init; }


    private static GLFW.WindowRef? Context { get; set; } = null;

    private bool _IsFullscreen;
    public bool IsFullscreen
    {
        get => _IsFullscreen;
        set
        {
            if (_IsFullscreen == value)
                return;

            if (_IsFullscreen)
            {
                var monitor = GLFW.GetPrimaryMonitor();
                var video = GLFW.GetVideoMode(monitor);
                GLFW.SetWindowMonitor(Ref, monitor, 0, 0, video.Width, video.Height, video.RefreshRate);
            }
            else
            {
                GLFW.SetWindowMonitor(Ref, GLFW.MonitorRef.Null, 0, 0, 0, 0, 0);
            }

            _IsFullscreen = value;
        }
    }

    private Window(GLFW.WindowRef r)
    {
        Ref = r;
        Input = new(r);
    }

    public static bool TryMake(WindowInfo info, [NotNullWhen(true)] out Window? window)
    {
        window = null;

        GLFW.WindowHint(GLFW.WindowHintType.ClientApi, GLFW.WindowValue.OpenGLAPI);
        GLFW.WindowHint(GLFW.WindowHintType.OpenGLProfile, GLFW.WindowValue.OpenGLCoreProfile);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMajor, 4);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMinor, 0);
        GLFW.WindowHint(GLFW.WindowHintType.Samples, 4);

        GLFW.WindowRef contextShare = (GLFW.WindowRef)(Context is null ? GLFW.WindowRef.Null : Context);

        var reference = GLFW.CreateWindow(info.Width, info.Height, info.Title, info.FullScreen ? GLFW.GetPrimaryMonitor() : GLFW.MonitorRef.Null, contextShare);
        if (reference.Raw == 0)
            return false;

        if (Context is null)
        {
            RenderThread.Do(() =>
            {
                GLFW.MakeContextCurrent(reference);
                Context = reference;
                GL.Load(GLFW.GetProcAddress);
            });
        }

        window = new(reference);
        return true;
    }

    internal void FinishFrame()
    {
        RenderThread.Do(() => GLFW.SwapBuffers(Ref));
        Input.Reset();
    }

    public bool ReceivedCloseMessage()
        => GLFW.WindowShouldClose(Ref);

}