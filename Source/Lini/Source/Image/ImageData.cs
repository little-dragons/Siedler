using Lini.Miscellaneous;

namespace Lini.Image;


public class ImageData
{
    public byte[] Bytes { get; set; } = default!;
    public int Width { get; set; }
    public int Height { get; set; }
    public PixelType PixelType { get; set; }

    public static ImageData? FromPNG(ReadOnlyMemory<byte> bytes)
        => PNG.PNGReader.ReadFromBytes(bytes);
    public static ImageData? FromPNG(string path)
    {
        Logger.Info($"Reading png file {path}.", Logger.Source.User);
        return PNG.PNGReader.ReadFromBytes(File.ReadAllBytes(path));
    }

    /// <summary>
    /// Tries to infer the type of image by the file extension.
    /// </summary>
    /// <param name="path">The path of the file. The extension of the file name is read and compared
    /// to the implemented methods.</param>
    /// <returns>Null if the image could not be read or the type of image could not be inferred.</returns>
    public static ImageData? FromFile(string path)
    {
        var info = new FileInfo(path);
        if (!info.Exists)
            return null;

        var bytes = File.ReadAllBytes(path);
        var name = info.Name;
        var dotSeparated = name.Split('.');
        if (!dotSeparated.Any())
            return null;

        var ext = dotSeparated.ElementAt(^1).ToLower();
        Logger.Info($"Trying to read file {path}.", Logger.Source.User);
        switch (ext) {
            case "png":
                return FromPNG(bytes);
            default:
                Logger.Info($"Could not infer image type for extension {ext}.", Logger.Source.User);
                return null;
        }
    }
}