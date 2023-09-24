namespace Lini.Image;


public class Image
{
    public byte[] Bytes { get; set; } = default!;
    public int Width { get; set; }
    public int Height { get; set; }
    public PixelType PixelType { get; set; }
}