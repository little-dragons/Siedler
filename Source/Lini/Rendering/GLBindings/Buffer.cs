using System.Runtime.InteropServices;
using Lini.Miscellaneous;

namespace Lini.Rendering.GLBindings;

internal sealed class Buffer<T> where T : unmanaged
{
    private sealed class BufferHandle : CriticalHandle
    {
        public BufferHandle(uint invalidHandleValue) : base((nint)invalidHandleValue)
        {
        }

        public override bool IsInvalid => handle < 0;
        public uint Value => (uint)handle;

        protected override bool ReleaseHandle()
        {
            var oldHandle = handle;
            handle = -1;
            RenderThread.Do(() => GL.DeleteBuffer((uint)oldHandle));
            return true;
        }
    }

    private BufferHandle Handle { get; init; }

    public BufferTarget Target { get; private set; }
    public BufferUsage Usage { get; private set; }

    public Buffer(BufferTarget target, BufferUsage usage)
    {
        Target = target;
        Usage = usage;

        Handle = new(GL.GenBuffer());
        GL.BindBuffer(Target, Handle.Value);
    }

    public void Write(ReadOnlySpan<T> data)
    {
        WarnIfInvalid();

        GL.BindBuffer(Target, Handle.Value);
        GL.BufferData(Target, data, Usage);
    }

    public void Bind()
    {
        WarnIfInvalid();
        GL.BindBuffer(Target, Handle.Value);
    }

    private void WarnIfInvalid()
    {
        if (Handle.IsInvalid)
            Logger.Warn("Tried to use invalid buffer handle.", Logger.Source.GL);
    }

    public void Delete()
    {
        WarnIfInvalid();
        Handle.Close();
    }
}