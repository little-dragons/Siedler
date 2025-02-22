using System.Collections.Immutable;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using Lini.Miscellaneous;

namespace Lini.Windowing.Input;

/// <summary>
/// Wraps the plain GLFW callbacks - some information is only available if you use the callbacks,
/// as such, there needs to be a class handling it and it is not really the responsibility of the
/// main class <see cref="Sam"/>.
/// 
/// Each instance of this class tracks a specific <see cref="Window"/> - since it registers
/// callbacks for this window, there may only be a single wrapper active per window, otherwise
/// the behavior will become undefined.
/// 
/// Each instance provides read access to the data collected from the callbacks and a <see cref="FinishFrame"/>
/// method which must be called in between each frame, otherwise data is not correctly aggregated.
/// </summary>
internal class GLFWInputWrapper
{
    /// <summary>
    /// The window for which callbacks were registered.
    /// </summary>
    public GLFW.WindowRef Window { get; init; }

    /// <summary>
    /// Constructs a new wrapper by registering callbacks and initialzing all class members.
    /// </summary>
    /// <param name="window">The window to which to register the callbacks. Callbacks shall not be
    /// registered for this window.</param>
    public GLFWInputWrapper(GLFW.WindowRef window)
    {
        Window = window;

        KeyCallback = KeyInput;
        if (GLFW.SetKeyCallback(Window, KeyCallback) != 0)
            Logger.Warn($"Key callback was already set for window \'{Window.Raw}\'", Logger.Source.GLFW);

        Decoder = new(!BitConverter.IsLittleEndian, false, true);
        CharCallback = CharInput;
        if (GLFW.SetCharCallback(Window, CharCallback) != 0)
            Logger.Warn($"Char callback was already set for window \'{Window.Raw}\'", Logger.Source.GLFW);

        MouseButtonCallback = MouseButtonInput;
        if (GLFW.SetMouseButtonCallback(Window, MouseButtonCallback) != 0)
            Logger.Warn($"Mouse button callback was already set for window \'{Window.Raw}\'", Logger.Source.GLFW);

        CursorPosCallback = CursorPosInput;
        if (GLFW.SetCursorPosCallback(Window, CursorPosCallback) != 0)
            Logger.Warn($"Cursor position callback was already set for window \'{Window.Raw}\'", Logger.Source.GLFW);

        KeyStates = [];
        foreach (var val in Enum.GetValues<Key>())
        {
            KeyStates.Add(val, GLFW.GetKey(Window, (GLFW.Key)val) == GLFW.KeyState.Press);
        }

        MouseButtons = [];
        foreach (var val in Enum.GetValues<MouseButton>())
        {
            MouseButtons.Add(val, GLFW.GetMouseButton(Window, (GLFW.MouseButton)val) == GLFW.KeyState.Press);
        }

        EventsQueue = new([]);
    }


    public InputEvent.Queue EventsQueue { get; private set; }
    public InputState State => new(KeyStates.ToImmutableDictionary(), MouseButtons.ToImmutableDictionary(), MousePosition);


    private Dictionary<Key, bool> KeyStates { get; init; }
    /// <summary>
    /// This delegate exists to prevent garbage collection on it: if a raw delgate was to be passed
    /// to the glfw methods, the same delegate will be garbage collected soon after and the next
    /// <see cref="GLFW.PollEvents"/> will trigger something worse than an exception. Therefore, the
    /// delegate is stored here.
    /// </summary>
    private GLFW.KeyFun KeyCallback { get; set; }
    private void KeyInput(GLFW.WindowRef window, GLFW.Key key, int scancode, GLFW.KeyState keystate, int mods)
    {
        switch (keystate)
        {
            case GLFW.KeyState.Press:
                EventsQueue = EventsQueue.Enqueue(new KeyPressedEvent((Key)key));
                break;
            case GLFW.KeyState.Release:
                EventsQueue = EventsQueue.Enqueue(new KeyReleasedEvent((Key)key));
                break;
        }
    }


    private Dictionary<MouseButton, bool> MouseButtons { get; init; }
    /// <summary>
    /// See the documentation of <see cref="KeyCallback"/>.
    /// </summary>
    private GLFW.MouseButtonFun MouseButtonCallback { get; set; }
    private void MouseButtonInput(GLFW.WindowRef window, GLFW.MouseButton button, GLFW.KeyState keystate, int mods)
    {
        switch (keystate)
        {
            case GLFW.KeyState.Press:
                EventsQueue = EventsQueue.Enqueue(new MouseButtonPressedEvent((MouseButton)button));
                break;
            case GLFW.KeyState.Release:
                EventsQueue = EventsQueue.Enqueue(new MouseButtonReleasedEvent((MouseButton)button));
                break;
        }
    }


    /// <summary>
    /// A decoder for the text sent by glfw. <see cref="Encoding.UTF32"/> may not be used since it always
    /// uses little-endian, which is not desired. glfw states that it uses the platform's native layout,
    /// that's why a new encoding is created.
    /// </summary>
    private UTF32Encoding Decoder { get; init; }

    /// <summary>
    /// See the documentation of <see cref="KeyCallback"/>.
    /// </summary>
    private GLFW.CharFun CharCallback { get; set; }
    private void CharInput(GLFW.WindowRef window, uint codepoint)
    {
        Span<uint> sp = new(ref codepoint);
        EventsQueue = EventsQueue.Enqueue(new TextInputEvent(Decoder.GetString(MemoryMarshal.AsBytes(sp))));
    }

    private Vector2 LastMousePosition { get; set; }
    private Vector2 MousePosition { get; set; }

    private GLFW.CursorPosFun CursorPosCallback { get; set; }
    private void CursorPosInput(GLFW.WindowRef window, double x, double y)
    {
        MousePosition = new((float)x, (float)y);
        EventsQueue = EventsQueue.Enqueue(new MouseMoveEvent(MousePosition - LastMousePosition, MousePosition));
    }


    /// <summary>
    /// Resets the data which needs to be reset after handled. It is imperative that this method is called
    /// whenever the previous data is handled and the callbacks may add new data.
    /// </summary>
    public void FinishFrame()
    {
        foreach (var ev in EventsQueue.Events)
            switch (ev)
            {
                case MouseButtonPressedEvent mbpe:
                    MouseButtons[mbpe.Button] = true;
                    break;
                case MouseButtonReleasedEvent mbre:
                    MouseButtons[mbre.Button] = false;
                    break;
                case KeyPressedEvent kpe:
                    KeyStates[kpe.Key] = true;
                    break;
                case KeyReleasedEvent kre:
                    KeyStates[kre.Key] = false;
                    break;
            }

        LastMousePosition = MousePosition;
        EventsQueue = new([]);
    }
}