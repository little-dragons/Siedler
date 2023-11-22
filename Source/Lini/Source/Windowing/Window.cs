using System.Diagnostics.CodeAnalysis;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing.Input;

namespace Lini.Windowing;

internal sealed class Window : IDisposable
{
    private GLFW.WindowRef Ref { get; init; }
    internal GLFWInputWrapper Input { get; init; }
    public WindowInfo Info { get; private set; }


    private static GLFW.WindowRef? SharedContext { get; set; } = null;



    /// <summary>
    /// This method may only be called from the main thread.
    /// </summary>
    internal void Apply(WindowInfo targetInfo)
    {
        if (targetInfo.IsFullscreen && targetInfo.FullscreenOptions.First != Info.FullscreenOptions.First)
        {
            var monitor = GLFW.GetPrimaryMonitor();
            var i = targetInfo.FullscreenOptions.First;
            GLFW.SetWindowMonitor(Ref, monitor, (0, 0), targetInfo.Resolution, targetInfo.RefreshRate);
        }
        else if (!targetInfo.IsFullscreen && targetInfo.FullscreenOptions.Second != Info.FullscreenOptions.Second)
        {
            var i = targetInfo.FullscreenOptions.Second!;
            GLFW.SetWindowMonitor(Ref, GLFW.MonitorRef.Null, i.Position ?? (0, 0), targetInfo.Resolution, targetInfo.RefreshRate);
        }
        if (targetInfo.CursorLocked != Info.CursorLocked)
        {
            if (targetInfo.CursorLocked)
                GLFW.SetInputMode(Ref, GLFW.InputMode.Cursor, GLFW.InputValue.CursorDisabled);
            else
                GLFW.SetInputMode(Ref, GLFW.InputMode.Cursor, GLFW.InputValue.CursorNormal);
        }
        if (targetInfo.Title != Info.Title)
            GLFW.SetWindowTitle(Ref, targetInfo.Title);

        Info = targetInfo;
    }


    private Window(GLFW.WindowRef r, WindowInfo info)
    {
        Ref = r;
        Input = new(r);
        Info = info;
    }

    public static bool TryMake(WindowInfo info, [NotNullWhen(true)] out Window? window)
    {
        window = null;

        GLFW.WindowHint(GLFW.WindowHintType.ClientApi, GLFW.WindowValue.OpenGLAPI);
        GLFW.WindowHint(GLFW.WindowHintType.OpenGLProfile, GLFW.WindowValue.OpenGLCoreProfile);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMajor, 4);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMinor, 0);
        GLFW.WindowHint(GLFW.WindowHintType.Samples, 4);

        GLFW.WindowRef contextShare = SharedContext is null ? GLFW.WindowRef.Null : SharedContext.Value;

        var reference = info.IsFullscreen switch
        {
            true => GLFW.CreateWindow(info.Resolution, info.Title, GLFW.GetPrimaryMonitor(), contextShare),
            false => GLFW.CreateWindow(info.Resolution, info.Title, GLFW.MonitorRef.Null, contextShare)
        };

        if (reference.Raw == 0)
            return false;

        if (info.FullscreenOptions.Second?.Position is not null)
            GLFW.SetWindowPos(reference, ((int, int))info.FullscreenOptions.Second.Position);


        if (SharedContext is null)
        {
            SharedContext = reference;
            RenderThread.Do(() =>
            {
                GLFW.MakeContextCurrent(reference);
                GL.Load(GLFW.GetProcAddress);
            });
            RenderThread.Finish();
        }

        GLFW.SetFramebufferSizeCallback(reference, (_, w, h) =>
        {
            RenderThread.Do(() => GL.Viewport(0, 0, w, h));
        });

        // if (GLFW.RawMouseMotionSupported())
        //     GLFW.SetInputMode(reference, GLFW.InputMode.RawMouseMotion, true);

        window = new(reference, info);
        return true;
    }

    internal void FinishFrame()
    {
        RenderThread.Do(() => GLFW.SwapBuffers(Ref));
        Input.Reset();
    }

    public bool ReceivedCloseMessage()
        => GLFW.WindowShouldClose(Ref);

    public void Dispose()
    {
        GLFW.DestroyWindow(Ref);
    }

    internal static void Terminate()
    {
        SharedContext = null;
    }
}