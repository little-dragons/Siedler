using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public struct Vertex : IVertex
{
    public Vector2 TextureCoordinates;
    public Vector3 Position;

    public static void SetGLAttributes()
    {
        GL.EnableVertexAttribArray(0);
        GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Marshal.SizeOf<Vertex>(), Marshal.OffsetOf<Vertex>(nameof(Position)));
        // GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, 0);

    }
}