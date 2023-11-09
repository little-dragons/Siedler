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
/// Each instance provides read access to the data collected from the callbacks and a <see cref="Reset"/>
/// method which must be called in between each frame, otherwise data is not correctly aggregated.
/// </summary>
internal class GLFWCallbacksWrapper : IInput
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
    public GLFWCallbacksWrapper(GLFW.WindowRef window)
    {
        Window = window;

        KeyCallback = KeyInput;
        if (GLFW.SetKeyCallback(Window, KeyCallback) != 0)
            Logger.Warn($"Key callback was already set for window \'{Window.Raw}\'", Logger.Source.GLFW);
        
        Decoder = new(!BitConverter.IsLittleEndian, false, true);
        CharCallback = CharInput;
        if (GLFW.SetCharCallback(Window, CharCallback) != 0)
            Logger.Warn($"Char callback was already set for window \'{Window.Raw}\'", Logger.Source.GLFW);


        foreach (var val in Enum.GetValues<Key>())
            Keys.Add(val, GLFW.GetKey(Window, (GLFW.Key)val) == GLFW.KeyState.Press);

        foreach (var val in Enum.GetValues<MouseButton>())
            MouseButtons.Add(val, GLFW.GetMouseButton(Window, (GLFW.Mouse)val) == GLFW.KeyState.Press);

        foreach (var val in Enum.GetValues<MouseAxis>())
            MouseAxes.Add(val, 0);

        Reset();
    }

    /// <summary>
    /// This delegate exists to prevent garbage collection on it: if a raw delgate was to be passed
    /// to the glfw methods, the same delegate will be garbage collected soon after and the next
    /// <see cref="GLFW.PollEvents"/> will trigger something worse than an exception. Therefore, the
    /// delegate is stored here.
    /// </summary>
    private GLFW.KeyFun KeyCallback { get; set; }

    private Dictionary<Key, bool> Keys { get; } = new();
    public bool IsDown(Key key)
        => Keys[key];
    
    /// <summary>
    /// This method handles a single key input event from glfw. It updates the state in <see cref="Keys"/>.
    /// It discards some parameters as those are not intendend to be used by the engine.
    /// </summary>
    private void KeyInput(GLFW.WindowRef window, GLFW.Key key, int scancode, GLFW.KeyState keystate, int mods)
    {
        Keys[(Key)key] = keystate switch
        {
            GLFW.KeyState.Release => false,
            _ => true
        };
    }


    private Dictionary<MouseButton, bool> MouseButtons { get; } = new();
    public bool IsDown(MouseButton button)
        => MouseButtons[button];


    /// <summary>
    /// A decoder for the text sent by glfw. <see cref="Encoding.UTF32"/> may not be used since it always
    /// uses little-endian, which is not desired. glfw states that it uses the platform's native layout,
    /// that's why a new encoding is created.
    /// </summary>
    private UTF32Encoding Decoder { get; init; }

    /// <summary>
    /// The text aggregated since the last call to <see cref="Reset"/>.
    /// </summary>
    public string Text { get; private set; } = "";
    
    /// <summary>
    /// See the documentation of <see cref="KeyCallback"/>.
    /// </summary>
    private GLFW.CharFun CharCallback { get; set; }
    private void CharInput(GLFW.WindowRef window, uint codepoint)
    {
        Span<uint> sp = new(ref codepoint);
        Text += Decoder.GetString(MemoryMarshal.AsBytes(sp));
    }


    private Vector2 LastMousePos { get; set; }
    private Dictionary<MouseAxis, float> MouseAxes { get; } = new();
    public float GetAxis(MouseAxis axis)
        => MouseAxes[axis];



    /// <summary>
    /// Resets the data which needs to be reset after handled. It is imperative that this method is called
    /// whenever the previous data is handled and the callbacks may add new data.
    /// </summary>
    public void Reset()
    {
        Text = "";
        LastMousePos = GLFW.GetCursorPos(Window);
        foreach (var (k, _) in MouseAxes)
        {
            MouseAxes[k] = 0;
        }
    }
}