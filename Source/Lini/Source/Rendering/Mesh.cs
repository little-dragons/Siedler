using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

public class Mesh<T> where T : unmanaged, IVertex
{
    public T[] Vertices { get; private set; }
    public ReadOnlySpan<T> VerticesSpan => new(Vertices);
    public uint[] Indices { get; private set; }
    public ReadOnlySpan<uint> IndicesSpan => new(Indices);

    internal Buffer<T> VertexBuffer { get; private set; } = default!;
    internal Buffer<uint> IndexBuffer { get; private set; } = default!;
    internal uint VertexArray { get; private set; }


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