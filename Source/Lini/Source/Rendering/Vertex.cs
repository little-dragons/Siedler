using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public struct Vertex : IVertex
{
    public Vector3 Position;
    public Vector2 TextureCoordinates;

    private static readonly int Size = Marshal.SizeOf<Vertex>();
    private static readonly nint PositionOffset = Marshal.OffsetOf<Vertex>(nameof(Position));
    private static readonly nint TextureCoordinatesOffset = Marshal.OffsetOf<Vertex>(nameof(TextureCoordinates));

    static void IVertex.SetVertexArrayAttributes()
    {
        SharedObjects.SimpleProgram.Bind();
        GL.EnableVertexAttribArray(0);
        GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Size, PositionOffset);
        
        GL.EnableVertexAttribArray(1);
        GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, Size, TextureCoordinatesOffset);
    }
}