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

    public Texture(Image.Image image)
    {
        Handle = new(GL.GenTexture());

        RenderThread.Do(() =>
        {
            GL.ActiveTexture(TextureUnit._0);
            GL.BindTexture(TextureTarget.Texture2d, Handle.Value);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMinFilter, TextureMinFilter.LinearMipmapLinear);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureMagFilter, TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureWrapS, TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2d, TextureParameterName.TextureWrapT, TextureWrapMode.Repeat);
            GL.PixelStore(PixelStoreParameter.UnpackAlignment, 1);
            GL.TexImage2D<byte>(TextureTarget.Texture2d, 0, InternalFormat.Rgb, image.Width, image.Height, 0, PixelFormat.Rgb, PixelType.UnsignedByte, new Span<byte>(image.Bytes));
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