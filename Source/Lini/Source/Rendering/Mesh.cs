using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public class Mesh<T> where T : unmanaged, IVertex
{
    private T[] Vertices { get; set; }
    public ReadOnlySpan<T> VerticesSpan => new(Vertices);
    private uint[] Indices { get; set; }
    public ReadOnlySpan<uint> IndicesSpan => new(Indices);

    private Buffer<T> VertexBuffer { get; set; } = default!;
    private Buffer<uint> IndexBuffer { get; set; } = default!;
    private uint VertexArray { get; set; }


    public Mesh(T[] vertices, uint[] indices)
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
        T.SetVertexArrayAttributes();
    }

    internal void Draw()
    {
        GL.BindVertexArray(VertexArray);
        GL.DrawElements(PrimitiveType.Triangles, Indices.Length, DrawElementsType.Int, 0);
    }
}