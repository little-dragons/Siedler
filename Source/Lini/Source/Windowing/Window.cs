using System.Diagnostics.CodeAnalysis;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing.Input;

namespace Lini.Windowing;

internal sealed partial class Window
{
    internal GLFW.WindowRef Handle { get; init; }
    private GLFWInputWrapper InputHandler { get; init; }
    public IInput Input => InputHandler;
    public WindowInfo Info { get; private set; }


    /// <summary>
    /// This method may only be called from the main thread.
    /// </summary>
    internal void Apply(WindowInfo targetInfo)
    {
        if (targetInfo.IsFullscreen && targetInfo.FullscreenOptions.First != Info.FullscreenOptions.First)
        {
            var monitor = GLFW.GetPrimaryMonitor();
            GLFW.SetWindowMonitor(Handle, monitor, (0, 0), targetInfo.Resolution, targetInfo.RefreshRate);
        }
        else if (!targetInfo.IsFullscreen && targetInfo.FullscreenOptions.Second != Info.FullscreenOptions.Second)
        {
            var i = targetInfo.FullscreenOptions.Second!;
            GLFW.SetWindowMonitor(Handle, GLFW.MonitorRef.Null, i.Position ?? (0, 0), targetInfo.Resolution, targetInfo.RefreshRate);
        }
        if (targetInfo.CursorLocked != Info.CursorLocked)
        {
            if (targetInfo.CursorLocked)
                GLFW.SetInputMode(Handle, GLFW.InputMode.Cursor, GLFW.InputValue.CursorDisabled);
            else
                GLFW.SetInputMode(Handle, GLFW.InputMode.Cursor, GLFW.InputValue.CursorNormal);
        }
        if (targetInfo.Title != Info.Title)
            GLFW.SetWindowTitle(Handle, targetInfo.Title);

        Info = targetInfo;
    }

    internal void FinishFrame()
    {
        RenderThread.Do(() => GLFW.SwapBuffers(Handle));
        InputHandler.Reset();
    }


    private Window(GLFW.WindowRef r, WindowInfo info)
    {
        Handle = r;
        InputHandler = new(r);
        Info = info;
    }

    private static bool TryMake(WindowInfo info, GLFW.WindowRef shared, [NotNullWhen(true)] out Window? window)
    {
        window = null;

        GLFW.WindowHint(GLFW.WindowHintType.ClientApi, GLFW.WindowValue.OpenGLAPI);
        GLFW.WindowHint(GLFW.WindowHintType.OpenGLProfile, GLFW.WindowValue.OpenGLCoreProfile);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMajor, 4);
        GLFW.WindowHint(GLFW.WindowHintType.ContextVersionMinor, 0);
        GLFW.WindowHint(GLFW.WindowHintType.Samples, 4);


        var handle = info.IsFullscreen switch
        {
            true => GLFW.CreateWindow(info.Resolution, info.Title, GLFW.GetPrimaryMonitor(), shared),
            false => GLFW.CreateWindow(info.Resolution, info.Title, GLFW.MonitorRef.Null, shared)
        };

        if (handle.Raw == 0)
            return false;

        if (info.FullscreenOptions.Second?.Position is not null)
            GLFW.SetWindowPos(handle, ((int, int))info.FullscreenOptions.Second.Position);



        GLFW.SetFramebufferSizeCallback(handle, (_, w, h) =>
        {
            RenderThread.Do(() => GL.Viewport(0, 0, w, h));
        });

        // if (GLFW.RawMouseMotionSupported())
        //     GLFW.SetInputMode(reference, GLFW.InputMode.RawMouseMotion, true);

        window = new(handle, info);
        return true;
    }

    public bool ReceivedCloseMessage()
        => GLFW.WindowShouldClose(Handle);

    private void Free()
    {
        GLFW.DestroyWindow(Handle);
    }
}
