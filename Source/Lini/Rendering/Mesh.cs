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

    internal Buffer<Vertex> VertexBuffer { get; private set; } = default!;
    internal Buffer<uint> IndexBuffer { get; private set; } = default!;
    internal uint VertexArray { get; private set; }


    public Mesh(Vertex[] vertices, uint[] indices)
    {
        Indices = indices;
        Vertices = vertices;

        RenderThread.Do(InitGL);
    }

    private void InitGL()
    {
        VertexArray = GL.GenVertexArray();
        GL.BindVertexArray(VertexArray);


        VertexBuffer = new(BufferTarget.Array, BufferUsage.StaticDraw);
        IndexBuffer = new(BufferTarget.ElementArray, BufferUsage.StaticDraw);
        VertexBuffer.Write(VerticesSpan);
        IndexBuffer.Write(IndicesSpan);
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