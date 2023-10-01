using System.IO.Compression;

namespace Lini.Stream;


/// <summary>
/// A stream to decompress zlib-data. Reading from this stream reads from the underlying data source.
/// and automatically decompresses it. 
/// TODO
/// Currently it only implements a simple deflate algorithm and ignores footer and headers.
/// </summary>
public class ZlibReadStream : IReadStream<byte>
{
    // TODO: Requires overall implementation of zlib values and not just png special cases
    // The public interface requires further work.

    private DeflateStream Deflater { get; set; }
    private SignatureStream<byte> Source { get; init; }


    /// <summary>
    /// Initalize a new stream for idat chunk decompression.
    /// </summary>
    public ZlibReadStream(IReadSeekStream<byte, byte> source)
    {
        Source = new SignatureStream<byte>(source, 2, 4);
        Deflater = new(LiniStreamWrapper.WrapRead(source), CompressionMode.Decompress);
    }

    public int Read(Span<byte> buffer)
        => Deflater.Read(buffer);
}