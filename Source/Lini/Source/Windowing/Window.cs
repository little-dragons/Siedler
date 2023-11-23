using System.Diagnostics.CodeAnalysis;
using Lini.Miscellaneous;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing.Input;

namespace Lini.Windowing;

/// <summary>
/// A window wrapper around glfw, providing a nicer interface through <see cref="WindowInfo"/> and <see cref="GLFWInputWrapper"/>. 
/// To create and destroy windows, see <see cref="Manager"/>.
/// </summary>
internal sealed partial class Window
{
    /// <summary>
    /// The handle of the window: after being destroyed, the handle is set to 0, marking this object as invalid.
    /// </summary>
    private GLFW.WindowRef Handle { get; set; }

    /// <summary>
    /// A wrapper around the glfw callbacks. It provides input for this window only.
    /// Since such a native wrapper should not be exposed directly, it can be accessed via <see cref="Input"/>.
    /// </summary>
    private GLFWInputWrapper InputHandler { get; init; }

    /// <summary>
    /// A wrapper to access the input presented since the last <see cref="FinishFrame"/>.
    /// </summary>
    public IInput Input => InputHandler;

    /// <summary>
    /// The current info of the window. This property may be changed only via the <see cref="Apply(WindowInfo)"/> method.
    /// </summary>
    public WindowInfo Info { get; private set; }


    /// <summary>
    /// This method may only be called from the main thread and uses many GLFW calls. Depending on what settings are changed,
    /// this may cause the window to flicker and lag quite a lot.
    /// </summary>
    internal void Apply(WindowInfo targetInfo)
    {
        WarnIfInvalid();
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

    /// <summary>
    /// This method maybe called whenever calculations for a frame are finished: it is going to swap the buffers and do other
    /// necessary operations like resetting the input.
    /// </summary>
    internal void FinishFrame()
    {
        WarnIfInvalid();
        RenderThread.Do(() => GLFW.SwapBuffers(Handle));
        InputHandler.Reset();
    }

    /// <summary>
    /// A private constructor only intended to set properties. Do not directly call this constructor, but call <see cref="TryMake"/>.
    /// </summary>
    private Window(GLFW.WindowRef r, WindowInfo info)
    {
        Handle = r;
        InputHandler = new(r);
        Info = info;
    }

    /// <summary>
    /// You may call this method to create a window. Note that it is private so that it can only be called by the embedded class
    /// <see cref="Manager"/>. To call this method, use <see cref="Manager.TryMake"/>.
    /// </summary>
    /// <param name="info">The initial info of this window.</param>
    /// <param name="shared">Any other window ref whose OpenGL context is going to be shared.</param>
    /// <param name="window">The result window.</param>
    /// <returns>True if the window could be created without issue. False if the operation could not be executed as expected.</returns>
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
        //     GLFW.SetInputMode(handle, GLFW.InputMode.RawMouseMotion, true);

        window = new(handle, info);
        return true;
    }

    /// <summary>
    /// Checks whether this window received a command from the operating system that it may close.
    /// </summary>
    public bool ReceivedCloseMessage()
    {
        WarnIfInvalid();
        return GLFW.WindowShouldClose(Handle);
    }

    /// <summary>
    /// Deletes and resets the handle of this window. This object may then not be used again. To call this method,
    /// use <see cref="Manager.Kill"/>.
    /// </summary>
    private void Free()
    {
        WarnIfInvalid();
        GLFW.DestroyWindow(Handle);
        Handle = GLFW.WindowRef.Null;
    }

    private void WarnIfInvalid()
    {
        if (Handle.Raw == 0)
            Logger.Warn("Tried to access window with invalid handle.", Logger.Source.GLFW);
    }
}
