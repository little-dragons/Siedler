using System.Numerics;
using System.Runtime.InteropServices;
using Lini.Image;
using Lini.Miscellaneous;
using Lini.Numerics;

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
    public bool IsValid => !Handle.IsInvalid;

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

        string info = GL.GetProgramInfoLog(Handle.Value);
        if (!string.IsNullOrEmpty(info))
            Logger.Error(info, Logger.Source.GL);

        foreach (var shader in shaders)
            shader.DetachFrom(Handle.Value);
    }

    public void Bind()
    {
        WarnIfInvalid();
        GL.UseProgram(Handle.Value);
    }

    /// <summary>
    /// If this was unmanaged code, caching the uniform values is probably not required
    /// since the <see cref="GL.GetUniformLocation(uint, string)"/> method is very fast anyway.
    /// However, since marshalling would be required, I assume that caching is actually faster to avoid
    /// the marshalling and P/Invoke overhead.
    /// </summary>
    private Dictionary<string, int> UniformLocations { get; init; } = new();

    public int GetLocation(string name)
    {
        if (!UniformLocations.TryGetValue(name, out int loc))
        {
            loc = GL.GetUniformLocation(Handle.Value, name);
            UniformLocations.Add(name, loc);
        }

        return loc;
    }

    public void SetUniform(string name, float value)
        => GL.Uniform(GetLocation(name), value);
    public void SetUniform(string name, int value)
        => GL.Uniform(GetLocation(name), value);
    public void SetUniform(string name, Vector2 value)
        => GL.Uniform(GetLocation(name), value);
    public void SetUniform(string name, Vector2i value)
        => GL.Uniform(GetLocation(name), value);
    public void SetUniform(string name, Vector3 value)
        => GL.Uniform(GetLocation(name), value);
    public void SetUniform(string name, Vector4 value)
        => GL.Uniform(GetLocation(name), value);

    /// <summary>
    /// This is an overload not really specified by OpenGL, it exists to make life simpler. Usually, 
    /// OpenGL requires a value starting at 0 to specify texture units.
    /// </summary>
    /// <param name="name">The name of the sampler in the shader.</param>
    /// <param name="value">The texture unit to use. It is internally converted to a valid OpenGL value.</param>
    public void SetUniform(string name, TextureUnit value)
        => GL.Uniform(GetLocation(name), (int)((uint)value - (uint)TextureUnit.Texture0));
        
    public void SetUniform(string name, Matrix4x4 value)
        => GL.Uniform(GetLocation(name), value);


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