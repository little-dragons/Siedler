
using System.Buffers.Binary;
using System.Text;
using Lini.Miscellaneous;
using Lini.Stream;

namespace Lini.Image.Png;

/// <summary>
/// implemented after https://en.wikipedia.org/wiki/Portable_Network_Graphics#File_format and https://www.w3.org/TR/png/
/// </summary>
internal static class PngReader
{
    private static readonly byte[] SignatureStart = { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A };



    /// <summary>
    /// Returns the type of the chunk and a byte span of the data.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="type">The type of the read chunk.</param>
    /// <returns>The data of the chunk read. It is a slice of <paramref name="bytes"/>.</returns>
    private static ReadOnlyMemory<byte> ReadChunk(ReadOnlyMemory<byte> bytes, out string type)
    {
        int length = BinaryPrimitives.ReadInt32BigEndian(bytes.Span);
        type = Encoding.ASCII.GetString(bytes.Span[4..8]);
        ReadOnlyMemory<byte> data = bytes[8..(8 + length)];
        int crc = BinaryPrimitives.ReadInt32BigEndian(bytes.Span[(8 + length)..]);

        //TODO: handle crc

        return data;
    }



    internal static Image? ReadFromBytes(ReadOnlyMemory<byte> bytes)
    {

        // match signature
        if (!bytes.Span[..SignatureStart.Length].SequenceEqual(SignatureStart))
        {
            Logger.Warn("Could not read png signature - are you sure this is a png file?", Logger.Source.User);
            return null;
        }

        int spanPosition = SignatureStart.Length;
        ReadOnlyMemory<byte> data = ReadChunk(bytes[spanPosition..], out string type);
        spanPosition += data.Length + 12;

        if (type is not "IHDR" || !IHDR.TryRead(data.Span, out IHDR ihdr))
        {
            Logger.Warn("Could not read header chunk of png file. Corrupt or invalid.", Logger.Source.User);
            return null;
        }


        Image result = new()
        {
            Width = ihdr.Width,
            Height = ihdr.Height,
            PixelType = ihdr.PixelType,
            Bytes = new byte[ihdr.Width * ihdr.Height * ihdr.PixelType.RequiredBytes],
        };


        ChunkedMemoryStream idatMemories = new();

        while (spanPosition < bytes.Length)
        {
            data = ReadChunk(bytes[spanPosition..], out type);
            spanPosition += data.Length + 12;

            // chunk is critical
            if (type[0] is >= 'A' and <= 'Z')
            {
                if (type is "IHDR")
                {
                    Logger.Warn("Encountered double header chunk.", Logger.Source.User);
                    return null;
                }
                else if (type is "PLTE")
                {
                    Logger.Warn("Cannot understand indexed files yet.", Logger.Source.User);
                    return null;
                }
                else if (type is "IDAT")
                {
                    idatMemories.Append(data);
                }
                else if (type is "IEND")
                {
                    if (spanPosition != bytes.Length)
                    {
                        Logger.Warn("Read end chunk while not at end.", Logger.Source.User);
                        return null;
                    }
                }
                else
                {
                    Logger.Warn("Did not understand critical chunk.", Logger.Source.User);
                    return null;
                }
            }
            else
            {
                Logger.Info($"Ignoring ancillary chunk of type: {type}", Logger.Source.User);
            }
        }


        using UnfilteringStream unfilter = new(ihdr, result.Bytes);
        ZlibReader idatReader = new(idatMemories);
        ((IReadStream<byte>)idatReader).CopyTo(SystemStreamWrapper.WrapWrite(unfilter));


        if (type is not "IEND")
        {
            Logger.Warn("Invalid fomat: end chunk was not last chunk.", Logger.Source.User);
            return null;
        }

        return result;
    }
}