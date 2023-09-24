using System.IO.Compression;
using Lini.Miscellaneous;

namespace Lini.Image.Png;

/// <summary>
/// A two way stream: Write the data from the compressed stream and you may read the decompressed values. Be sure that because of various reasons,
/// you must always check how much can actually be read from the stream.
/// </summary>
public class ZlibReader : System.IO.Stream
{
    // TODO: Requires overall implementation of zlib values and not just png special cases
    // The public interface requires further work.

    private int _Length { get; set; }
    private int _Position { get; set; }
    private DeflateStream Deflater { get; set; }
    private ChunkedMemoryReader MemoryReader { get; init; }

    public override bool CanRead => Deflater.CanRead;
    public override bool CanSeek => false;
    public override bool CanWrite => true;
    public override long Length => _Length;
    public override long Position { get => _Position; set => throw new NotImplementedException(); }


    /// <summary>
    /// Initalize a new stream for idat chunk decompression.
    /// </summary>
    public ZlibReader()
    {
        MemoryReader = new();
        Deflater = new(MemoryReader, CompressionMode.Decompress);
        _Length = int.MaxValue;
        _Position = 0;
    }

    public override void Write(byte[] buffer, int offset, int count)
        => Write(new ReadOnlyMemory<byte>(buffer, offset, count));
    public override void Write(ReadOnlySpan<byte> span)
        => throw new NotSupportedException("This inherited deflate stream can only accept data through the ReadOnlyMemory<byte> overload");
    public override void WriteByte(byte value)
        => throw new NotSupportedException("This inherited deflate stream can only accept data through the ReadOnlyMemory<byte> overload");


    /// <summary>
    /// Sets the input length. Make sure this is set correctly before reading.
    /// </summary>
    /// <param name="streamLength">The entire length of all the contents. Can be set to int.MaxValue, 
    /// but has to be set correctly before reading.</param>
    public override void SetLength(long streamLength)
    {
        if (streamLength < 6)
        {
            Logger.Warn("Invalid stream length for zlib decompressor: at least 6 bytes of content are required.", Logger.Source.User);
            // this will maybe lead to unexpected behaviour.
        }

        _Length = (int)streamLength;

        // cut elements too long
        if (MemoryReader.Length > _Length - 4)
        {
            long cache = MemoryReader.Position;
            MemoryReader.Position = MemoryReader.Length - 4;
            MemoryReader.CutAfter();
            MemoryReader.Position = cache;
        }
    }

    public void Write(ReadOnlyMemory<byte> memory)
    {
        // because of zlib (we're ignoring that), we need to cut the first two bytes and the last 4
        if (_Position < 2)
        {
            int toCut = Math.Min(2 - _Position, memory.Length);
            memory = memory.Slice(toCut);
            _Position += toCut;

            if (memory.Length == 0)
                return;
        }
        if (_Position + memory.Length > _Length - 4)
        {
            int toCut = Math.Min(_Position + memory.Length - _Length - 4, memory.Length);
            int start = memory.Length - toCut;
            memory = memory.Slice(start, toCut);
            _Position += toCut;

            if (memory.Length == 0)
                return;
        }

        if (_Position + memory.Length > _Length)
        {
            Logger.Warn("More data than previously announced. Can not handle that.", Logger.Source.User);
            // no idea what to do - we can only warn
        }

        MemoryReader.AddMemory(memory);
        _Position += memory.Length;
    }


    public override int Read(byte[] buffer, int offset, int count)
        => Deflater.Read(buffer, offset, count);
    public override int Read(Span<byte> buffer)
        => Deflater.Read(buffer);

    
    public override long Seek(long offset, SeekOrigin origin)
        => throw new NotImplementedException();
    public override void Flush()
        => throw new NotImplementedException();
}