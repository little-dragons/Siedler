using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public struct Vertex : IVertex
{
    public Vector3 Position;
    public Vector2 TextureCoordinates;

    public static void SetVertexArrayAttributes()
    {
        SharedObjects.SimpleProgram.Bind();
        GL.EnableVertexAttribArray(0);
        GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Marshal.SizeOf<Vertex>(), Marshal.OffsetOf<Vertex>(nameof(Position)));
        
        GL.EnableVertexAttribArray(1);
        GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, Marshal.SizeOf<Vertex>(), Marshal.OffsetOf<Vertex>(nameof(TextureCoordinates)));
    }
}