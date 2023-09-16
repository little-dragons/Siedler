using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public struct Vertex
{
    public Vector2 TextureCoordinates;
    public Vector3 Position;

    internal static void SetVertexArrayAttributes()
    {
        GL.EnableVertexAttribArray(0);
        GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Marshal.SizeOf<Vertex>(), Marshal.OffsetOf<Vertex>(nameof(Position)));
    }
}