using Lini.Graph.Components;
using Lini.Graph.Components.BuiltIn;

namespace Lini.Graph;

public class Scene
{
    public ComponentRef<Camera> ActiveCamera { get; set; }
    public Entity Root { get; init; }

    internal ComponentsPool Components { get; init; }


    public Scene()
    {
        Root = new(this);
        Components = new();
    }

    internal Entity NewEntity()
        => new(this);


    internal void UpdateAll(UpdateArgs args)
    {
        Components.Update(args);
    }

    internal void Render3D(Render3DArgs args)
    {
        args.Program.SetUniform("view", Components.Get(ActiveCamera).ViewMatrix);
        args.Program.SetUniform("projection", Components.Get(ActiveCamera).ProjectionMatrix);

        Root.Render3D(args);
    }

    internal void RenderUI(RenderUIArgs args)
        => Root.RenderUI(args);
}