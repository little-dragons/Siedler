using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Rendering;
using Lini.Rendering.GLBindings;

namespace Lini.UI;

public struct Point : IVertex
{
    public Vector2 Percent;
    public Vector2 Offset;

    public static void SetVertexArrayAttributes()
    {
        SharedObjects.UIProgram.Bind();
        GL.EnableVertexAttribArray(0);
        GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, Marshal.SizeOf<Point>(), Marshal.OffsetOf<Point>(nameof(Percent)));
        
        GL.EnableVertexAttribArray(1);
        GL.VertexAttribPointer(1, 2, VertexAttribPointerType.Float, false, Marshal.SizeOf<Point>(), Marshal.OffsetOf<Point>(nameof(Offset)));
    }
}