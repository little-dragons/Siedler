using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Rendering;
using Lini.Rendering.GLBindings;

namespace Lini.UI;

public struct Point : IVertex
{
    public Vector2 Percent;
    public Vector2 Offset;

    private static readonly int Size = Marshal.SizeOf<Point>();
    private static readonly nint PercentOffset = Marshal.OffsetOf<Point>(nameof(Percent));
    private static readonly nint OffsetOffset = Marshal.OffsetOf<Point>(nameof(Offset));

    static void IVertex.SetVertexArrayAttributes()
    {
        SharedObjects.UIProgram.Bind();

        GL.EnableVertexAttribArray(0);
        GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, Size, PercentOffset);
        
        GL.EnableVertexAttribArray(1);
        GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, Size, OffsetOffset);
    }
}