using Lini.Rendering;
using Lini.Rendering.GLBindings;

namespace Lini.Graph.Components.BuiltIn;

public struct MeshRenderer : IComponent, IRenderable
{
    static int IComponent.TypeID { get; set; }
    
    public Mesh Mesh { get; private set; }
    public Texture? Texture { get; private set; }


    public MeshRenderer(Mesh mesh)
    {
        Mesh = mesh;
    }

    public MeshRenderer(Mesh mesh, Texture texture)
        : this(mesh)
    {
        Texture = texture;
    }

    readonly void IRenderable.Render(RenderArgs args)
    {
        args.Program.SetUniform("model", args.Transforms.Peek());

        if (Texture is not null)
        {
            GL.ActiveTexture(0);
            Texture.Bind();
            args.Program.SetUniform("tex", 0);
        }

        Mesh.Draw();
    }
}