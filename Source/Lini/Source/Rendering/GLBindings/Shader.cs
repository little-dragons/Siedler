using System.Runtime.InteropServices;
using Lini.Miscellaneous;

namespace Lini.Rendering.GLBindings;

internal class Shader
{
    private sealed class ShaderHandle : CriticalHandle
    {
        public ShaderHandle(uint invalidHandleValue) : base((nint)invalidHandleValue)
        {
        }

        public override bool IsInvalid => handle < 0;
        public uint Value => (uint)handle;

        protected override bool ReleaseHandle()
        {
            var oldHandle = handle;
            handle = -1;
            RenderThread.Do(() => GL.DeleteShader((uint)oldHandle));
            return true;
        }
    }

    private ShaderHandle Handle { get; set; }
    internal ShaderType Type { get; private set; }

    public Shader(ShaderType type, string source)
    {
        Type = type;
        Handle = new(GL.CreateShader(Type));

        GL.ShaderSource(Handle.Value, source);
        GL.CompileShader(Handle.Value);
        string info = GL.GetShaderInfoLog(Handle.Value);
        if (!string.IsNullOrEmpty(info))
            Logger.Error(info, Logger.Source.GL);
    }

    internal void AttachTo(uint program)
    {
        GL.AttachShader(program, Handle.Value);
    }

    internal void DetachFrom(uint program)
    {
        GL.DetachShader(program, Handle.Value);
    }

    private void WarnIfInvalid()
    {
        if (Handle.IsInvalid)
            Logger.Warn("Tried to access invalidated.", Logger.Source.GL);
    }

    public void Delete()
    {
        WarnIfInvalid();
        Handle.Close();
    }
}