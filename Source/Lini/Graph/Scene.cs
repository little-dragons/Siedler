using Lini.Graph.Components;

namespace Lini.Graph;

public class Scene
{
    public Camera ActiveCamera { get; set; } = new();
    public Entity Root { get; init; } = new();

    internal void Render(RenderArgs args)
    {
        args.Program.SetUniform("view", ActiveCamera.ViewMatrix);
        args.Program.SetUniform("projection", ActiveCamera.ProjectionMatrix);

        ((IRenderable)Root).Render(args);
    }
}