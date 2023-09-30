using System.Buffers.Binary;
using System.Numerics;
using Lini.Miscellaneous;

namespace Lini.Image.Png;

internal struct IHDR
{
    internal const byte CompressionStandard = 0;
    internal const byte FilterStandard = 0;


    internal int Width { get; set; }
    internal int Height { get; set; }

    internal byte BitDepth { get; set; }
    internal ColorType ColorType { get; set; }
    internal byte Compression { get; set; }
    internal byte Filter { get; set; }
    internal Interlace Interlace { get; set; }

    internal PixelType PixelType { get; set; }



    /// <summary>
    /// Construct an instance of this class from the content the chunk.
    /// </summary>
    /// <param name="content">The exact content of the chunk.</param>
    /// <param name="ihdr">The chunk. Only use this if true is returned.</param>
    /// <returns>True if the chunk could be read successfully.</returns>
    internal static bool TryRead(ReadOnlySpan<byte> content, out IHDR ihdr)
    {
        ihdr = new();
        if (content.Length is not 13) {
            Logger.Warn("The content is not of the expected length.", Logger.Source.User);
            return false;
        }

        ihdr = new()
        {
            Width = BinaryPrimitives.ReadInt32BigEndian(content),
            Height = BinaryPrimitives.ReadInt32BigEndian(content[4..]),
            BitDepth = content[8],
            ColorType = (ColorType)content[9],
            Compression = content[10],
            Filter = content[11],
            Interlace = (Interlace)content[12]
        };

        ihdr.PixelType = ihdr.ColorType switch
        {
            ColorType.Grayscale => PixelType.FromGrayscale(ihdr.BitDepth),
            ColorType.Truecolor => PixelType.FromRGB(ihdr.BitDepth),
            ColorType.Indexed => PixelType.FromGrayscale(0), // indexed color not implemented
            ColorType.GrayscaleAlpha => PixelType.FromTransparentGrayscale(ihdr.BitDepth, ihdr.BitDepth),
            ColorType.TruecolorAlpha => PixelType.FromTransparentRGB(ihdr.BitDepth, ihdr.BitDepth, ihdr.BitDepth, ihdr.BitDepth),
            _ => PixelType.FromGrayscale(0)
        };

        if (ihdr.PixelType.RequiredBytes == 0)
        {
            Logger.Warn("Something went wrong while reading the color type of the png.", Logger.Source.User);
            return false;
        }

        if (BitOperations.PopCount(ihdr.BitDepth) != 1) {
            Logger.Warn("Invalid bit depth.", Logger.Source.User);
            return false;
        }

        if (ihdr.ColorType == ColorType.Indexed && ihdr.BitDepth > 8)
        {
            Logger.Warn("Could not identify correct bit depth for paletted png.", Logger.Source.User);
            return false;
        }

        if (ihdr.ColorType >= ColorType.GrayscaleAlpha && ihdr.BitDepth is not 8 or 16)
        {
            Logger.Warn("Could not identify correct bit depth for png.", Logger.Source.User);
            return false;
        }

        if (ihdr.Compression != CompressionStandard) {
            Logger.Warn("Unknown compression algorithm.", Logger.Source.User);
            return false;
        }

        if (ihdr.Filter != FilterStandard) {
            Logger.Warn("Unknown filtering algorithm.", Logger.Source.User);
            return false;
        }

        if (ihdr.Interlace is not Interlace.None or Interlace.Adam7) {
            Logger.Warn("Unknown interlace algorithm.", Logger.Source.User);
            return false;
        }

        return true;
    }
}