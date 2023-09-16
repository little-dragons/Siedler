using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public class Mesh
{
    public Material? Material { get; private set; }
    public Texture? Texture { get; private set; }

    public Vertex[] Vertices { get; private set; }
    public Span<Vertex> VerticesSpan => new(Vertices);
    public uint[] Indices { get; private set; }
    public Span<uint> IndicesSpan => new(Indices);

    internal uint VertexBuffer { get; private set; }
    internal uint IndexBuffer { get; private set; }
    internal uint VertexArray { get; private set; }


    public Mesh(Vertex[] vertices, uint[] indices)
    {
        Indices = indices;
        Vertices = vertices;

        RenderThread.Do(Create);
    }

    private void Create()
    {
        VertexArray = GL.GenVertexArray();
        GL.BindVertexArray(VertexArray);

        VertexBuffer = GL.GenBuffer();
        IndexBuffer = GL.GenBuffer();
        GL.BindBuffer(BufferTarget.Array, VertexBuffer);
        GL.BindBuffer(BufferTarget.ElementArray, IndexBuffer);
        GL.BufferData<Vertex>(BufferTarget.Array, VerticesSpan, BufferUsage.StaticDraw);
        GL.BufferData<uint>(BufferTarget.ElementArray, IndicesSpan, BufferUsage.StaticDraw);
        Vertex.SetVertexArrayAttributes();
    }

    internal void Draw()
    {
        RenderThread.Do(() =>
        {
            GL.BindVertexArray(VertexArray);
            GL.DrawElements(PrimitiveType.Triangles, Indices.Length, DrawElementsType.Int, 0);
        });
    }
}