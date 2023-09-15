using System.Runtime.InteropServices;
using Lini.Rendering;
using Lini.Rendering.GLBindings;
using Lini.Windowing;

namespace Lini;

public static class Sam
{
    public static GLFW.WindowRef WindowRef { get; private set; }

    public static void Initialize(WindowInfo winInfo)
    {
        GLFW.Init();
        GLFW.WindowHint(GLFW.ContextVersionMajor, 4);
        GLFW.WindowHint(GLFW.ContextVersionMinor, 2);
        WindowRef = GLFW.CreateWindow(winInfo.Width, winInfo.Height, winInfo.Title, winInfo.FullScreen ? GLFW.GetPrimaryMonitor() : GLFW.MonitorRef.Null, 0);
        GLFW.MakeContextCurrent(WindowRef);
        GL.Load(GLFW.GetProcAddress);

        
        GL.DebugProc callback = (s, t, id, sev, message) =>
        {
            Console.WriteLine("GL debug callback says: " + message);
        };

        GL.Enable(EnableCap.DebugOutput);

        GL.DebugMessageCallback(callback);
        GL.DebugMessageInsert(DebugSource.Application, DebugType.Marker, 0, DebugSeverity.Notification, "Test message injected.");




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

        GL.ClearColor(1.0f, 0.5f, 0.2f, 1.0f);

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
    }

    public static void Terminate() {
        GLFW.Terminate();
    }

    public static void Run(Mesh mesh)
    {


        // var vertBuffer = GL.GenBuffer();
        // var indexBuffer = GL.GenBuffer();

        // var vao = GL.GenVertexArray();

        // GL.BindVertexArray(vao);

        // GL.BindBuffer(BufferTarget.Array, vertBuffer);
        // var vertices =
        //     new float[9] { 0.5f, -0.5f, 0.0f, -0.5f, -0.5f, 0.0f, 0.0f, 0.75f, 0.0f };
        // ReadOnlySpan<float> vertSpan = new(vertices);

        // GL.BufferData(BufferTarget.Array, vertSpan, BufferUsage.StaticDraw);

        // GL.BindBuffer(BufferTarget.ElementArray, indexBuffer);
        // var indices =
        //     new uint[3] { 0, 1, 2 };
        // ReadOnlySpan<uint> indicesSpan = new(indices);
        // GL.BufferData(BufferTarget.ElementArray, indicesSpan, BufferUsage.StaticDraw);


        // GL.EnableVertexAttribArray(0);
        // GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);


        while (!GLFW.WindowShouldClose(WindowRef))
        {
            GL.Clear(ClearBufferMask.Color);

            // GL.DrawElements(PrimitiveType.Triangles, 3, DrawElementsType.Int, 0);
            mesh.Draw();

            GLFW.PollEvents();
            GLFW.SwapBuffers(WindowRef);
        }

        GLFW.Terminate();

    }
}
