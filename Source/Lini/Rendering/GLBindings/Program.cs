using System.Runtime.InteropServices;
using Lini.Miscellaneous;

namespace Lini.Rendering.GLBindings;

internal class Program
{
    private sealed class ProgramHandle : CriticalHandle
    {
        public ProgramHandle(uint invalidHandleValue) : base((nint)invalidHandleValue)
        {
        }

        public override bool IsInvalid => handle < 0;
        public uint Value => (uint)handle;

        protected override bool ReleaseHandle()
        {
            var oldHandle = handle;
            handle = -1;
            RenderThread.Do(() => GL.DeleteProgram((uint)oldHandle));
            return true;
        }
    }

    private ProgramHandle Handle { get; }

    public Program(IEnumerable<Shader> shaders)
    {
        Handle = new(GL.CreateProgram());
        foreach (var shader in shaders)
            shader.AttachTo(Handle.Value);

        GL.LinkProgram(Handle.Value);

        foreach (var shader in shaders)
            shader.DetachFrom(Handle.Value);
    }

    public void Bind()
    {
        GL.UseProgram(Handle.Value);
    }

    private void WarnIfInvalid()
    {
        if (Handle.IsInvalid)
            Logger.Warn("Tried to use invalid program handle.", Logger.Source.GL);
    }

    public void Delete()
    {
        WarnIfInvalid();
        Handle.Close();
    }
}