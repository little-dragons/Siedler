using Lini.Graph.Components;
using Lini.Graph.Components.BuiltIn;

namespace Lini.Graph;

public class Layer
{
    public required int Index { get; init; }
    public required Scene Scene { get; init; }

    public Entity Root { get; init; }
    public ComponentRef<Camera>? ActiveCamera { get; set; }
    internal ComponentsPool Components { get; init; }

    public Layer()
    {
        Root = new(this);
        Components = new();
    }


    internal void Render3D(Render3DArgs args)
    {
        if (ActiveCamera is null)
            return;

        args.Program.SetUniform("view", Components.Get(ActiveCamera.Value).ViewMatrix);
        args.Program.SetUniform("projection", Components.Get(ActiveCamera.Value).ProjectionMatrix);

        Root.Render3D(args);
    }

    internal void RenderUI(RenderUIArgs args)
        => Root.RenderUI(args);
}