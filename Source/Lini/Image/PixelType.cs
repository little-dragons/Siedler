namespace Lini.Image;

/// <summary>
/// Stores the required bits for each component.
/// </summary>
public readonly struct PixelType
{
    public PixelType(int red, int green, int blue, int alpha, int gray)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
        Gray = gray;
    }

    /// <summary>
    /// How many bits will be required for the red component.
    /// </summary>
    public int Red { get; }
    /// <summary>
    /// How many bits will be required for the green component.
    /// </summary>
    public int Green { get; }
    /// <summary>
    /// How many bits will be required for the blue component.
    /// </summary>
    public int Blue { get; }

    /// <summary>
    /// How many bits will be stored for the transparency value. This is the only component that can be set everytime.
    /// </summary>
    public int Alpha { get; }

    /// <summary>
    /// How many bits will be stored for the grayscale component. If this is set, no other color component
    /// may be set.
    /// </summary>
    public int Gray { get; }


    /// <summary>
    /// How many bits are required to store one pixel of this type.
    /// </summary>
    public int RequiredBits => Red + Green + Blue + Alpha + Gray;


    /// <summary>
    /// How many bytes are required to store one pixel of this type.
    /// </summary>
    public int RequiredBytes => RequiredBits / 8 + (RequiredBits % 8 is 0 ? 0 : 1);



    public static PixelType FromTransparentGrayscale(int grey, int alpha)
    {
        return new(0, 0, 0, alpha, grey);
    }

    public static PixelType FromGrayscale(int grey)
    {
        return new(0, 0, 0, 0, grey);
    }

    public static PixelType FromRGB(int all) => FromRGB(all, all, all);
    public static PixelType FromRGB(int r, int g, int b)
    {
        return new(r, g, b, 0, 0);
    }

    public static PixelType FromTransparentRGB(int r, int g, int b, int a)
    {
        return new(r, g, b, a, 0);
    }
}