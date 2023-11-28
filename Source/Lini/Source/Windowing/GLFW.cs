namespace Lini.Windowing;

using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Numerics;

internal static class GLFW
{
    internal const string LibName = "glfw";

    // this warning is because "the fields Raw are never set and will always have their default
    // value" - apparently not, stupid compiler lol
#pragma warning disable CS0649
    internal readonly struct WindowRef
    {
        internal readonly IntPtr Raw;
        internal static readonly WindowRef Null = new();
    }
    internal readonly struct MonitorRef
    {
        internal readonly IntPtr Raw;
        internal static readonly MonitorRef Null = new();
    }
#pragma warning restore CS0649


    internal enum WindowHintType
    {
        Focused = 0x00020001,
        Resizable = 0x00020003,
        Visible = 0x00020004,
        Decorated = 0x00020005,
        AutoIconify = 0x00020006,
        Floating = 0x00020007,
        Maximized = 0x00020008,
        CenterCursor = 0x00020009,
        TransparentFramebuffer = 0x0002000A,
        FocusOnShow = 0x0002000C,
        RedBits = 0x00021001,
        GreenBits = 0x00021002,
        BlueBits = 0x00021003,
        AlphaBits = 0x00021004,
        DepthBits = 0x00021005,
        StencilBits = 0x00021006,
        AccumRedBits = 0x00021007,
        AccumGreenBits = 0x00021008,
        AccumBlueBits = 0x00021009,
        AccumAlphaBits = 0x0002100A,
        AuxBuffers = 0x0002100B,
        Stereo = 0x0002100C,
        Samples = 0x0002100D,
        SRGBCapable = 0x0002100E,
        RefreshRate = 0x0002100F,
        DoubleBuffer = 0x00021010,
        ClientApi = 0x00022001,
        ContextVersionMajor = 0x00022002,
        ContextVersionMinor = 0x00022003,
        ContextRevision = 0x00022004,
        ContextRobustness = 0x00022005,
        OpenGLForwardCompat = 0x00022006,
        OpenGLDebugContext = 0x00022007,
        OpenGLProfile = 0x00022008,
        ContextReleaseBehavior = 0x00022009,
        ContextNoError = 0x0002200A,
        ContextCreationAPI = 0x0002200B,
    }

    internal enum InputMode
    {
        Cursor = 0x00033001,
        StickyKeys = 0x00033002,
        StickyMouseButtons = 0x00033003,
        LockKeyMods = 0x00033004,
        RawMouseMotion = 0x00033005,
    }
    internal enum InputValue
    {
        CursorDisabled = 0x00034003,
        CursorHidden = 0x00034002,
        CursorNormal = 0x00034001,
    }

    internal enum WindowAttributeType
    {
        Focused = 0x00020001,
        Iconified = 0x00020002,
        Resizable = 0x00020003,
        Visible = 0x00020004,
        Decorated = 0x00020005,
        AutoIconify = 0x00020006,
        Floating = 0x00020007,
        Maximized = 0x00020008,
        TransparentFramebuffer = 0x0002000A,
        Hovered = 0x0002000B,
        FocusOnShow = 0x0002000C,
        ClientApi = 0x00021011,
        ContextVersionMajor = 0x00022002,
        ContextVersionMinor = 0x00022003,
        ContextRevision = 0x00022004,
        ContextRobustness = 0x00022005,
        OpenGLForwardCompat = 0x00022006,
        OpenGLDebugContext = 0x00022007,
        OpenGLProfile = 0x00022008,
        ContextReleaseBehavior = 0x00022009,
        ContextNoError = 0x0002200A,
    }

    internal enum WindowValue
    {
        NoAPI = 0,
        OpenGLAPI = 0x00030001,
        OpenGLESAPI = 0x00030002,

        OpenGLAnyProfile = 0,
        OpenGLCoreProfile = 0x00032001,
        OpenGLCompatProfile = 0x00032002,
    }

    internal enum KeyState
    {
        Release = 0,
        Press = 1,
        Repeat = 2,
    }

    internal enum Key
    {
        Space = 32,
        Apostrophe = 39,
        Comma = 44,
        Minus = 45,
        Period = 46,
        Slash = 47,
        _0 = 48,
        _1 = 49,
        _2 = 50,
        _3 = 51,
        _4 = 52,
        _5 = 53,
        _6 = 54,
        _7 = 55,
        _8 = 56,
        _9 = 57,
        Semicolon = 59,
        Equal = 61,
        A = 65,
        B = 66,
        C = 67,
        D = 68,
        E = 69,
        F = 70,
        G = 71,
        H = 72,
        I = 73,
        J = 74,
        K = 75,
        L = 76,
        M = 77,
        N = 78,
        O = 79,
        P = 80,
        Q = 81,
        R = 82,
        S = 83,
        T = 84,
        U = 85,
        V = 86,
        W = 87,
        X = 88,
        Y = 89,
        Z = 90,
        LeftBracket = 91,
        Backslash = 92,
        RightBracket = 93,
        GraveAccent = 96,
        Escape = 256,
        Enter = 257,
        Tab = 258,
        Backspace = 259,
        Insert = 260,
        Delete = 261,
        Right = 262,
        Left = 263,
        Down = 264,
        Up = 265,
        PageUp = 266,
        PageDown = 267,
        Home = 268,
        End = 269,
        CapsLock = 280,
        ScrollLock = 281,
        NumLock = 282,
        PrintScreen = 283,
        Pause = 284,
        F1 = 290,
        F2 = 291,
        F3 = 292,
        F4 = 293,
        F5 = 294,
        F6 = 295,
        F7 = 296,
        F8 = 297,
        F9 = 298,
        F10 = 299,
        F11 = 300,
        F12 = 301,
        LeftShift = 340,
        LeftControl = 341,
        LeftAlt = 342,
        RightShift = 344,
        RightControl = 345,
        RightAlt = 346
    }
    internal enum Mod
    {
        Shift = 0x1,
        Control = 0x2,
        Alt = 0x4,
        Super = 0x8,
        CapsLock = 0x10,
        NumLock = 0x20,
    }
    internal enum MouseButton
    {
        Left = 0,
        Right = 1,
        Middle = 2
    }

    internal enum ErrorCode
    {
        NoError = 0,
        NotInitialized = 0x00010001,
        NoCurrentContext = 0x00010002,
        InvalidEnum = 0x00010003,
        InvalidValue = 0x00010004,
        OutOfMemory = 0x00010005,
        ApiUnavailable = 0x00010006,
        VersionUnavailable = 0x00010007,
        PlatformError = 0x00010008,
        FormatUnavailable = 0x00010009,
        NoWindowContext = 0x0001000A,
    }



    [DllImport(LibName, EntryPoint = "glfwInit")]
    internal static extern bool Init();

    [DllImport(LibName, EntryPoint = "glfwTerminate")]
    internal static extern void Terminate();


    [DllImport(LibName, EntryPoint = "glfwGetVersion")]
    internal static extern void GetVersion(out int major, out int minor, out int revision);
    internal static Version GetVersion()
    {
        GetVersion(out int major, out int minor, out int rev);
        return new(major, minor, rev);
    }

    [DllImport(LibName, EntryPoint = "glfwCreateWindow")]
    internal static extern WindowRef CreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, MonitorRef monitor, WindowRef share);
    internal static WindowRef CreateWindow(Vector2i dimension, string title, MonitorRef monitor, WindowRef share) {
        return CreateWindow(dimension.X, dimension.Y, title, monitor, share);
    }

    [DllImport(LibName, EntryPoint = "glfwWindowShouldClose")]
    internal static extern bool WindowShouldClose(WindowRef window);

    [DllImport(LibName, EntryPoint = "glfwSetInputMode")]
    internal static extern void SetInputMode(WindowRef window, InputMode mode, bool value);
    [DllImport(LibName, EntryPoint = "glfwSetInputMode")]
    internal static extern void SetInputMode(WindowRef window, InputMode mode, InputValue value);


    [DllImport(LibName, EntryPoint = "glfwPollEvents")]
    internal static extern void PollEvents();

    [DllImport(LibName, EntryPoint = "glfwMakeContextCurrent")]
    internal static extern void MakeContextCurrent(WindowRef window);

    [DllImport(LibName, EntryPoint = "glfwWindowHint")]
    internal static extern void WindowHint(WindowHintType hint, WindowValue value);

    
    [DllImport(LibName, EntryPoint = "glfwSetWindowPos")]
    internal static extern void SetWindowPos(WindowRef window, int xpos, int ypos);
    internal static void SetWindowPos(WindowRef window, Vector2i pos)
        => SetWindowPos(window, pos.X, pos.Y);

    internal static void SetWindowPos(WindowRef window, (int, int) position)
        => SetWindowPos(window, position.Item1, position.Item2);

    [DllImport(LibName, EntryPoint = "glfwWindowHint")]
    internal static extern void WindowHint(WindowHintType hint, int value);

    [DllImport(LibName, EntryPoint = "glfwSwapBuffers")]
    internal static extern void SwapBuffers(WindowRef window);

    [DllImport(LibName, EntryPoint = "glfwGetProcAddress")]
    internal static extern IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);

    [DllImport(LibName, EntryPoint = "glfwGetPrimaryMonitor")]
    internal static extern MonitorRef GetPrimaryMonitor();

    [DllImport(LibName, EntryPoint = "glfwGetKey")]
    internal static extern KeyState GetKey(WindowRef window, Key key);

    [DllImport(LibName, EntryPoint = "glfwGetMouseButton")]
    internal static extern KeyState GetMouseButton(WindowRef window, MouseButton button);


    [DllImport(LibName, EntryPoint = "glfwSetWindowMonitor")]
    internal static extern void SetWindowMonitor(WindowRef window, MonitorRef monitor, int xpos, int ypos, int width, int height, int refreshRate);

    internal static void SetWindowMonitor(WindowRef window, MonitorRef monitor, Vector2i position, Vector2i dimension, int refreshRate)
    {
        SetWindowMonitor(window, monitor, position.X, position.Y, dimension.X, dimension.Y, refreshRate);
    }

    [DllImport(LibName, EntryPoint = "glfwSetWindowTitle")]
    internal static extern void SetWindowTitle(WindowRef window, [MarshalAs(UnmanagedType.LPStr)] string title);

    [DllImport(LibName, EntryPoint = "glfwGetVideoMode")]
    internal static extern ref readonly VideoMode GetVideoMode(MonitorRef monitor);

    [DllImport(LibName, EntryPoint = "glfwSwapInterval")]
    internal static extern void SwapInterval(bool useVsync);




    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate void ErrorFun(ErrorCode errorCode, [MarshalAs(UnmanagedType.LPStr)] string message);

    [DllImport(LibName, EntryPoint = "glfwSetErrorCallback")]
    internal static extern ErrorFun SetErrorCallback(ErrorFun errorFun);





    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate void CharFun(WindowRef window, uint codepoint);

    [DllImport(LibName, EntryPoint = "glfwSetCharCallback")]
    internal static extern IntPtr SetCharCallback(WindowRef window, CharFun charFun);





    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate void KeyFun(WindowRef window, Key key, int scancode, KeyState action, int mods);

    [DllImport(LibName, EntryPoint = "glfwSetKeyCallback")]
    internal static extern IntPtr SetKeyCallback(WindowRef window, KeyFun keyFun);


    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate void MouseButtonFun(WindowRef window, MouseButton button, KeyState action, int mods);

    [DllImport(LibName, EntryPoint = "glfwSetMouseButtonCallback")]
    internal static extern IntPtr SetMouseButtonCallback(WindowRef window, MouseButtonFun keyFun);




    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate void CursorPosFun(WindowRef window, double x, double y);
    [DllImport(LibName, EntryPoint = "glfwSetCursorPosCallback")]
    internal static extern IntPtr SetCursorPosCallback(WindowRef window, CursorPosFun posFun);



    [DllImport(LibName, EntryPoint = "glfwGetCursorPos")]
    internal static extern void GetCursorPos(WindowRef window, out double xPos, out double yPos);

    internal static Vector2 GetCursorPos(WindowRef window)
    {
        GetCursorPos(window, out double x, out double y);
        return new()
        {
            X = (float)x,
            Y = (float)y
        };
    }

    [DllImport(LibName, EntryPoint = "glfwRawMouseMotionSupported")]
    internal static extern bool RawMouseMotionSupported();

    [DllImport(LibName, EntryPoint = "glfwDestroyWindow")]
    internal static extern void DestroyWindow(WindowRef window);

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate void WindowSizeFun(WindowRef window, int width, int height);
    [DllImport(LibName, EntryPoint = "glfwSetWindowSizeCallback")]
    internal static extern IntPtr SetWindowSizeCallback(WindowRef window, WindowSizeFun callback);

    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    internal delegate void FramebufferSizeFun(WindowRef window, int width, int height);
    [DllImport(LibName, EntryPoint = "glfwSetFramebufferSizeCallback")]
    internal static extern IntPtr SetFramebufferSizeCallback(WindowRef window, FramebufferSizeFun callback);

    [StructLayout(LayoutKind.Sequential)]
    internal struct VideoMode
    {
        internal int Width;
        internal int Height;
        internal int RedBits;
        internal int GreenBits;
        internal int BlueBits;
        internal int RefreshRate;
    }
}