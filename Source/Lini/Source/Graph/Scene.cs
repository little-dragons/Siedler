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
    
    // internal ComponentRef<T> NewComponent<T>() where T : struct, IComponent
    //     => Components.Add<T>();

    // internal void DeleteComponent<T>(ComponentRef<T> comp) where T : struct, IComponent 
    //     => Components.Delete(comp);


    internal void UpdateAll(UpdateArgs args)
    {
        Components.Update(args);
    }

    internal void Render(RenderArgs args)
    {
        args.Program.SetUniform("view", Components.Get(ActiveCamera).ViewMatrix);
        args.Program.SetUniform("projection", Components.Get(ActiveCamera).ProjectionMatrix);

        Root.Render(args);
    }
}