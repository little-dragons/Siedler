using System.Diagnostics.CodeAnalysis;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing.Input;

namespace Lini.Windowing;

public class Window
{
    private GLFW.WindowRef Ref { get; init; }
    internal GLFWInputWrapper Input { get; init; }


    private static GLFW.WindowRef? Context { get; set; } = null;

    public bool IsFullscreen { get; private set; }
    public void MakeFullscreen()
    {
        var monitor = GLFW.GetPrimaryMonitor();
        var video = GLFW.GetVideoMode(monitor);
        GLFW.SetWindowMonitor(Ref, monitor, 0, 0, video.Width, video.Height, video.RefreshRate);
        IsFullscreen = true;
    }

    public void MakeWindow((int, int) position, (int, int) dimension, int refreshRate)
    {
        GLFW.SetWindowMonitor(Ref, GLFW.MonitorRef.Null, position.Item1, position.Item2, dimension.Item1, dimension.Item2, refreshRate);
        IsFullscreen = false;
    }

    private Window(GLFW.WindowRef r, bool isFullscreen)
    {
        Ref = r;
        Input = new(r);
        IsFullscreen = isFullscreen;

        GLFW.SetFramebufferSizeCallback(Ref, (_, w, h) => {
            RenderThread.Do(() => GL.Viewport(0, 0, w, h));
        });
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
            Context = reference;
            RenderThread.Do(() =>
            {
                GLFW.MakeContextCurrent(reference);
                GL.Load(GLFW.GetProcAddress);
            });
            RenderThread.Finish();
        }

        if (GLFW.RawMouseMotionSupported())
            GLFW.SetInputMode(reference, GLFW.InputMode.RawMouseMotion, true);

        window = new(reference, info.FullScreen);
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