using System.Numerics;
using Lini.Numerics;
using Lini.Rendering;
using Lini.UI;

namespace Lini.Graph.Components.BuiltIn;

public struct Button : IComponent, IRenderableUI
{
    static int IComponent.TypeID { get; set; }
    public static bool RendersUI => true;
    public static bool Renders3D => false;

    public Rectangle Box { get; private set; }
    public Vector4 BackgroundColor { get; set; }

    private Mesh<Point> Mesh { get; set; }

    public bool IsHovered{ get; private set; }

    public Button(Rectangle box)
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

    public void Update(UpdateArgs args)
    {
        Vector2 corrected = args.State.MousePosition;
        corrected.Y = args.CurrentWindowInfo.Resolution.Y - corrected.Y;
        IsHovered = Box.Contains((Vector2i)corrected, args.CurrentWindowInfo.Resolution);
        Console.WriteLine(corrected);
        if (IsHovered) {
            Console.WriteLine("Hovering over button");
        }
    }  
}