using Lini.Rendering;

namespace Lini.Scene.Components;

public class MeshRenderer : Component
{
    public Mesh Mesh { get; private set; }

    public MeshRenderer(Mesh mesh)
    {
        Mesh = mesh;
    }

    public override void Render(RenderArgs args) {
        
    }
}