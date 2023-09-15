using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public class Mesh
{
    public Material? Material { get; private set; }
    public Texture? Texture { get; private set; }

    public Vertex[] Vertices { get; private set; }
    public ReadOnlySpan<Vertex> VerticesSpan => new(Vertices);
    public uint[] Indices { get; private set; }
    public ReadOnlySpan<uint> IndicesSpan => new(Indices);

    public Mesh(Vertex[] vertices, uint[] indices)
    {
        Indices = indices;
        Vertices = vertices;

        VAO = GL.GenVertexArray();
        GL.BindVertexArray(VAO);

        VertexBuffer = GL.GenBuffer();
        IndexBuffer = GL.GenBuffer();
        GL.BindBuffer(BufferTarget.Array, VertexBuffer);
        GL.BindBuffer(BufferTarget.ElementArray, IndexBuffer);
        GL.BufferData(BufferTarget.Array, VerticesSpan, BufferUsage.StaticDraw);
        GL.BufferData(BufferTarget.ElementArray, IndicesSpan, BufferUsage.StaticDraw);
        Vertex.SetGLAttributes();
        
        GL.BindVertexArray(0);
    }

    internal uint VertexBuffer;
    internal uint IndexBuffer;
    internal uint VAO;


    internal void Draw()
    {
        GL.BindVertexArray(VAO);
        GL.DrawElements(PrimitiveType.Triangles, Indices.Length, DrawElementsType.Int, 0);
        GL.BindVertexArray(0);
    }
}