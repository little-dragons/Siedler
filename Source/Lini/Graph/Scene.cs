using System.Numerics;
using Lini.Graph.Components;
using Lini.Rendering;

namespace Lini.Graph;

public class Scene
{
    public Camera ActiveCamera { get; set; } = new();
    public Entity Root { get; init; } = new();

    internal void Render(RenderArgs args)
    {
        Matrix4x4 camTransform = ActiveCamera.Entity!.AbsoluteTransform;
        var eye = Vector3.Transform(Vector3.Zero, camTransform);
        var up = Vector3.TransformNormal(Vector3.UnitY, camTransform);
        var target = Vector3.Transform(Vector3.UnitZ, camTransform);

        args.Program.SetUniform("view", Matrix4x4.CreateLookAt(eye, target, up));
        args.Program.SetUniform("projection", ActiveCamera.ProjectionMatrix);

        ((IRenderable)Root).Render(args);
    }
}