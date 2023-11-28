using Lini.Rendering;
using Lini.Rendering.GLBindings;

namespace Lini.Graph.Components.BuiltIn;

public struct MeshRenderer : IComponent, IRenderable3D
{
    static int IComponent.TypeID { get; set; }
    public static bool RendersUI => false;
    public static bool Renders3D => true;
    
    public Mesh<Vertex> Mesh { get; private set; }
    public Texture? Texture { get; private set; }


    public MeshRenderer(Mesh<Vertex> mesh)
    {
        Mesh = mesh;
    }

    public MeshRenderer(Mesh<Vertex> mesh, Texture texture)
        : this(mesh)
    {
        Texture = texture;
    }

    readonly void IRenderable3D.Render(Render3DArgs args)
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