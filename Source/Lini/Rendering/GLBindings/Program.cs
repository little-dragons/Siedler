using System.Numerics;
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
        if (!shaders.Any(x => x.Type == ShaderType.Vertex))
            Logger.Warn("The given shaders did not include a vertex shader.", Logger.Source.GL);

        if (!shaders.Any(x => x.Type == ShaderType.Fragment))
            Logger.Warn("The given shaders did not include a fragment shader.", Logger.Source.GL);

        if (shaders.DistinctBy(x => x.Type).Count() < shaders.Count())
        {
            Logger.Warn("The given shaders included multiple shaders of type(s):" +
                $"{shaders.Where(x => shaders.Where(y => y.Type == x.Type).Count() > 1).Aggregate("", string.Concat)}.",
                Logger.Source.GL);
        }

        Handle = new(GL.CreateProgram());
        foreach (var shader in shaders)
            shader.AttachTo(Handle.Value);

        GL.LinkProgram(Handle.Value);

        foreach (var shader in shaders)
            shader.DetachFrom(Handle.Value);
    }

    public void Bind()
    {
        WarnIfInvalid();
        GL.UseProgram(Handle.Value);
    }


    private readonly Dictionary<string, int> UniformLocations = new();
    public void SetUniform<T>(string name, T value) where T : unmanaged
    {
        WarnIfInvalid();
        if (!UniformLocations.TryGetValue(name, out int loc))
        {
            loc = GL.GetUniformLocation(Handle.Value, name);
            UniformLocations.Add(name, loc);
        }

        if (value is float v1)
            GL.Uniform(loc, v1);
        else if (value is Vector2 v2)
            GL.Uniform(loc, v2);
        else if (value is Vector3 v3)
            GL.Uniform(loc, v3);
        else if (value is Vector4 v4)
            GL.Uniform(loc, v4);
        else if (value is Matrix4x4 mat4)
            GL.Uniform(loc, mat4);
        else
            Logger.Warn($"Could not set uniform of type {typeof(T)}.", Logger.Source.GL);
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