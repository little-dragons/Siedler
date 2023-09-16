using Lini.Rendering.GLBindings;

namespace Lini.Rendering;

internal interface IRenderTask
{
    internal abstract void Do();
}

internal readonly struct DeleteBufferTask : IRenderTask
{
    internal readonly uint Handle;

    internal DeleteBufferTask(uint handle)
    {
        Handle = handle;
    }

    readonly void IRenderTask.Do()
        => GL.DeleteBuffer(Handle);
}

internal readonly struct DrawVAOTask : IRenderTask
{
    internal readonly uint Handle;
    internal readonly int Count;

    internal DrawVAOTask(uint handle, int count)
    {
        Handle = handle;
        Count = count;
    }

    readonly void IRenderTask.Do()
    {
        GL.BindVertexArray(Handle);
        GL.DrawElements(PrimitiveType.Triangles, Count, DrawElementsType.Int, 0);
    }
}

internal readonly struct ActionTask : IRenderTask
{
    internal readonly Action Action;

    public ActionTask(Action action)
    {
        Action = action;
    }

    readonly void IRenderTask.Do()
        => Action();
}

internal readonly struct ClearTask : IRenderTask
{

    readonly void IRenderTask.Do()
        => GL.Clear(ClearBufferMask.Color);
}