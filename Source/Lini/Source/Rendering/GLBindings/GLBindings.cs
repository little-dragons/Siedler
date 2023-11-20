using System.Numerics;
using System.Runtime.InteropServices;

namespace Lini.Rendering.GLBindings;

internal static partial class GL
{
    internal static void ShaderSource(uint shader, string source)
    {
        var ptr = Marshal.StringToHGlobalAnsi(source);
        var len = source.Length;
        ShaderSourceInstance(shader, 1, in ptr, in len);
        Marshal.FreeHGlobal(ptr);
    }

    internal static void ClearColor(float v1, float v2, float v3, float v4)
    {
        ClearColorInstance(v1, v2, v3, v4);
    }

    internal static uint CreateProgram()
    {
        return CreateProgramInstance();
    }

    internal static uint CreateShader(ShaderType type)
    {
        return CreateShaderInstance(type);
    }

    internal static void CompileShader(uint shader)
    {
        CompileShaderInstance(shader);
    }

    internal static void AttachShader(uint program, uint shader)
    {
        AttachShaderInstance(program, shader);
    }

    internal static void LinkProgram(uint program)
    {
        LinkProgramInstance(program);
    }

    internal static void BindVertexArray(uint vao)
    {
        BindVertexArrayInstance(vao);
    }

    internal static void EnableVertexAttribArray(uint index)
    {
        EnableVertexAttribArrayInstance(index);
    }

    internal static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, nint offset)
    {
        VertexAttribPointerInstance(index, size, type, normalized, stride, offset);
    }

    internal static ErrorCode GetError()
    {
        return GetErrorInstance();
    }

    internal static string GetShaderInfoLog(uint shader)
    {
        int size = GetShader(shader, ShaderParameterName.InfoLogLength);
        if (size == 0)
            return "";
        var ptr = Marshal.AllocCoTaskMem(size);
        GetShaderInfoLogInstance(shader, size, out int len, ptr);
        string res = Marshal.PtrToStringAnsi(ptr, len)!;
        Marshal.FreeCoTaskMem(ptr);
        return res;
    }

    internal static int GetShader(uint shader, ShaderParameterName pname)
    {
        GetShaderivInstance(shader, pname, out int res);
        return res;
    }

    internal static void UseProgram(uint program)
    {
        UseProgramInstance(program);
    }

    internal static void BindBuffer(BufferTarget target, uint buffer)
    {
        BindBufferInstance(target, buffer);
    }

    internal static void BufferData<T>(BufferTarget target, ReadOnlySpan<T> data, BufferUsage usage) where T : unmanaged
    {
        BufferDataInstance(target, data.Length * Marshal.SizeOf<T>(), in MemoryMarshal.GetReference(MemoryMarshal.AsBytes(data)), usage);
    }

    internal static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, int offset)
    {
        DrawElementsInstance(mode, count, type, offset);
    }

    internal static void Clear(ClearBufferMask mask)
    {
        ClearInstance(mask);
    }

    internal static string GetString(StringName name)
    {
        var ptr = GetStringInstance(name);
        return Marshal.PtrToStringAnsi(ptr)!;
    }

    internal static void DebugMessageCallback(DebugProc callback)
    {
        PrivateDebugProc wrapper = (src, t, id, sev, l, msg, up) =>
        {
            callback(src, t, id, sev, Marshal.PtrToStringAnsi(msg, l)!);
        };
        DebugMessageCallbackInstance(wrapper, 0);
    }

    internal static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, string message)
    {
        var ptr = Marshal.StringToCoTaskMemAnsi(message);
        DebugMessageInsertInstance(source, type, id, severity, message.Length, ptr);
        Marshal.FreeCoTaskMem(ptr);
    }

    internal static void Enable(EnableCap cap)
    {
        EnableInstance(cap);
    }

    internal static void DeleteBuffer(uint buffer)
    {
        DeleteBuffersInstance(1, in buffer);
    }

    internal static void DeleteShader(uint handle)
    {
        DeleteShaderInstance(handle);
    }

    internal static void DetachShader(uint program, uint shader)
    {
        DetachShaderInstance(program, shader);
    }

    internal static void DeleteProgram(uint handle)
    {
        DeleteProgramInstance(handle);
    }

    internal static int GetUniformLocation(uint program, string name)
    {
        return GetUniformLocationInstance(program, name);
    }
    internal static void Uniform(int location, float value)
    {
        Uniform1fInstance(location, value);
    }
    internal static void Uniform(int location, int value)
    {
        Uniform1iInstance(location, value);
    }
    internal static void Uniform(int location, Vector2 vector)
    {
        Uniform2fInstance(location, vector.X, vector.Y);
    }
    internal static void Uniform(int location, in Vector3 vector)
    {
        Uniform3fInstance(location, vector.X, vector.Y, vector.Z);
    }
    internal static void Uniform(int location, in Vector4 vector)
    {
        Uniform4fInstance(location, vector.X, vector.Y, vector.Z, vector.W);
    }
    internal static void Uniform(int location, in Matrix4x4 mat)
    {
        UniformMatrix4fvInstance(location, 1, false, in mat.M11);
    }

    internal static void DeleteTexture(uint handle)
    {
        DeleteTexturesInstance(1, handle);
    }

    internal static void BindTexture(TextureTarget target, uint value)
    {
        BindTextureInstance(target, value);
    }

    // internal static void TexParameter(TextureTarget target, TextureParameterName pname)
    // {
    //     TexParameteriInstance(target, pname, SpecialNumbers.Repeat);
    // }

    internal static void TexImage2D<T>(
        TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border,
        PixelFormat format, PixelType type, ReadOnlySpan<T> pixels) where T : unmanaged
    {
        TexImage2DInstance(target, level, internalformat, width, height, border, format, type, in MemoryMarshal.GetReference(MemoryMarshal.AsBytes(pixels)));
    }

    internal static void ActiveTexture(TextureUnit unit)
    {
        ActiveTextureInstance(unit);
    }


    /// <summary>
    /// The value of <paramref name="unit"/> is used as the texture unit, it does not have to follow OpenGL
    /// values. This should make the api simpler to use.
    /// </summary>
    /// <param name="unit">The value of the texture unit starting at the value 0. It is internally converted to a valid texture uint
    internal static void ActiveTexture(int unit)
    {
        ActiveTextureInstance((TextureUnit)(unit + (uint)TextureUnit.Texture0));
    }

    internal static void GenerateMipmap(TextureTarget target)
    {
        GenerateMipmapInstance(target);
    }

    internal static void TexParameter(TextureTarget target, TextureParameterName pname, TextureMagFilter value)
    {
        TexParameteriInstance(target, pname, (int)value);
    }
    internal static void TexParameter(TextureTarget target, TextureParameterName pname, TextureMinFilter value)
    {
        TexParameteriInstance(target, pname, (int)value);
    }
    internal static void TexParameter(TextureTarget target, TextureParameterName pname, TextureWrapMode value)
    {
        TexParameteriInstance(target, pname, (int)value);
    }
    internal static void PixelStore(PixelStoreParameter pname, int value)
    {
        PixelStoreiInstance(pname, value);
    }
    internal static void PixelStore(PixelStoreParameter pname, float value)
    {
        PixelStorefInstance(pname, value);
    }

    internal static void Viewport(int x, int y, int w, int h)
    {
        ViewportInstance(x, y, w, h);
    }

}