using Lini.Graph.Components;

namespace Lini.Graph;

public class Scene
{
    public Camera ActiveCamera { get; set; } = new();
    public Entity Root { get; init; } = new();

    private ComponentList ComponentList { get; init; }

    public ComponentRef MakeComponent<T>() where T : unmanaged, IComponent
        => ComponentList.Make<T>();

    public bool TryGetComponent<T>(ComponentRef key, out T component) where T : unmanaged, IComponent
    {

    }

    internal void Render(RenderArgs args)
    {
        args.Program.SetUniform("view", ActiveCamera.ViewMatrix);
        args.Program.SetUniform("projection", ActiveCamera.ProjectionMatrix);

        ((IRenderable)Root).Render(args);
    }
}