using System.Runtime.InteropServices;
using Lini.Image;
using Lini.Miscellaneous;

namespace Lini.Rendering.GLBindings;

internal class Texture
{
    private sealed class TextureHandle : CriticalHandle
    {
        public TextureHandle(uint invalidHandleValue) : base((nint)invalidHandleValue)
        {
        }

        public override bool IsInvalid => handle < 0;
        public uint Value => (uint)handle;

        protected override bool ReleaseHandle()
        {
            var oldHandle = handle;
            handle = -1;
            RenderThread.Do(() => GL.DeleteTexture((uint)oldHandle));
            return true;
        }
    }

    private TextureHandle Handle { get; init; }




    public Texture(ImageData image)
    {
        Handle = new(GL.GenTexture());

        if (!image.PixelType.TryDetermineGLFormat(out var internalFormat, out var pixelFormat))
        {
            Logger.Warn($"Pixel format for {image.PixelType} could not be determined. Texture data is not loaded.", Logger.Source.GL);
            return;
        }

        RenderThread.Do(() =>
        {
            GL.BindTexture(TextureTarget.Texture2d, Handle.Value);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, TextureMinFilter.LinearMipmapLinear);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, TextureWrapMode.Repeat);
            GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);
            GL.TexImage2D<byte>(TextureTarget.Texture2d, 0, internalFormat, image.Width, image.Height, 0, pixelFormat, PixelType.UnsignedByte, new Span<byte>(image.Bytes));
            GL.GenerateMipmap(TextureTarget.Texture2d);
        });
    }

    public void Bind()
    {
        WarnIfInvalid();
        GL.BindTexture(TextureTarget.Texture2d, Handle.Value);
    }

    public void Delete()
    {
        WarnIfInvalid();
        Handle.Close();
    }

    private void WarnIfInvalid()
    {
        if (Handle.IsInvalid)
            Logger.Warn("Tried to access invalid texture.", Logger.Source.GL);
    }
}

internal static class PixelTypeExtension  {


    public static bool TryDetermineGLFormat(this Image.PixelType pt, out InternalFormat internalFormat, out PixelFormat pixelFormat) {
        internalFormat = 0;
        pixelFormat = 0;

        if (pt.Red == 8 & pt.Blue == 8 && pt.Green == 8)
        {
            if (pt.Alpha == 8)
            {
                internalFormat = InternalFormat.Rgba;
                pixelFormat = PixelFormat.Rgba;
            }
            else if (pt.Alpha == 0)
            {
                internalFormat = InternalFormat.Rgb;
                pixelFormat = PixelFormat.Rgb;
            }
        }

        return internalFormat != 0 && pixelFormat != 0;
    }
}