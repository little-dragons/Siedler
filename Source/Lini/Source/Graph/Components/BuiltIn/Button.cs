using System.Numerics;
using Lini.Image;
using Lini.Rendering;
using Lini.UI;

namespace Lini.Graph.Components.BuiltIn;

public struct Button : IComponent, IRenderableUI
{
    static int IComponent.TypeID { get; set; }
    public static bool RendersUI => true;
    public static bool Renders3D => false;

    public Box Box { get; private set; }
    public Vector4 BackgroundColor { get; set; }

    private Mesh<Point> Mesh { get; set; }

    public Button(Box box)
    {
        Box = box;
        var vertices = box.ToArray();
        uint[] indices = [0, 1, 2, 0, 1, 3];
        Mesh = new(vertices, indices);
    }

    readonly void IRenderableUI.Render(RenderUIArgs args)
    {
        args.Program.SetUniform("fillColor", BackgroundColor);
        Mesh.Draw();
    }
}