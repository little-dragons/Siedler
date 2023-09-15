namespace Lini.Windowing;

using System.Runtime.InteropServices;

public static class GLFW
{
    public const string LibName = "glfw";
    public readonly struct WindowRef
    {
        public readonly IntPtr Raw;
    }
    public readonly struct MonitorRef
    {
        public readonly IntPtr Raw;
        public static readonly MonitorRef Null = new();
    }

    [DllImport(LibName, EntryPoint = "glfwInit")]
    public static extern int Init();

    [DllImport(LibName, EntryPoint = "glfwTerminate")]
    public static extern void Terminate();

    [DllImport(LibName, EntryPoint = "glfwCreateWindow")]
    public static extern WindowRef CreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, MonitorRef monitor, IntPtr _2);

    [DllImport(LibName, EntryPoint = "glfwWindowShouldClose")]
    public static extern bool WindowShouldClose(WindowRef window);

    [DllImport(LibName, EntryPoint = "glfwPollEvents")]
    public static extern void PollEvents();

    [DllImport(LibName, EntryPoint = "glfwMakeContextCurrent")]
    public static extern void MakeContextCurrent(WindowRef window);

    [DllImport(LibName, EntryPoint = "glfwWindowHint")]
    public static extern void WindowHint(int hint, int value);

    [DllImport(LibName, EntryPoint = "glfwSwapBuffers")]
    public static extern void SwapBuffers(WindowRef window);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void GLProc();

    [DllImport(LibName, EntryPoint = "glfwGetProcAddress")]
    public static extern IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);

    [DllImport(LibName, EntryPoint = "glfwGetPrimaryMonitor")]
    public static extern MonitorRef GetPrimaryMonitor();
    

    public const int ContextVersionMajor = 0x00022002;
    public const int ContextVersionMinor = 0x00022003;


}