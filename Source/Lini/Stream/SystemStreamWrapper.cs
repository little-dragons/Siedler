namespace Lini.Stream;

public sealed class SystemStreamWrapper : IReadWriteSeekStream<byte, byte, byte>
{
    private System.IO.Stream Wrapped { get; init; }
    public long Position
    {
        get => Wrapped.Position;
        set
        {
            if (!Wrapped.CanSeek)
                throw new NotSupportedException("Cannot seek in a system stream which does not support seeking.");

            Wrapped.Seek(value, SeekOrigin.Begin);
        }
    }

    public void Seek(long val)
        => Wrapped.Seek(val, SeekOrigin.Begin);
    public void SeekEnd(long val)
        => Wrapped.Seek(val, SeekOrigin.End);
    public void SeekOffset(long val)
        => Wrapped.Seek(val, SeekOrigin.Current);

    public long Length => Wrapped.Length;

    private SystemStreamWrapper(System.IO.Stream stream)
    {
        Wrapped = stream;
    }


    public static IReadStream<byte> WrapRead(System.IO.Stream stream)
    {
        if (!stream.CanRead)
            throw new NotSupportedException("Cannot build a read stream from a system stream which does not support reading.");

        return new SystemStreamWrapper(stream);
    }
    public static IWriteStream<byte> WrapWrite(System.IO.Stream stream)
    {
        if (!stream.CanWrite)
            throw new NotSupportedException("Cannot build a write stream from a system stream which does not support writing.");

        return new SystemStreamWrapper(stream);
    }
    public static IReadWriteStream<byte, byte> WrapReadWrite(System.IO.Stream stream)
    {
        if (!stream.CanWrite || !stream.CanRead)
            throw new NotSupportedException("Cannot build a read-write stream from a system stream which does not support reading or writing.");

        return new SystemStreamWrapper(stream);
    }
    public static IReadWriteSeekStream<byte, byte, byte> WrapReadWriteSeek(System.IO.Stream stream)
    {
        if (!stream.CanWrite || !stream.CanRead || !stream.CanSeek)
            throw new NotSupportedException("Cannot build a read-write-seek stream from a system stream which does not support reading, writing or seeking.");

        return new SystemStreamWrapper(stream);
    }
    public static IReadSeekStream<byte, byte> WrapReadSeek(System.IO.Stream stream)
    {
        if (!stream.CanRead || !stream.CanSeek)
            throw new NotSupportedException("Cannot build a read-seek stream from a system stream which does not support reading or seeking.");

        return new SystemStreamWrapper(stream);
    }
    public static IWriteSeekStream<byte, byte> WrapWriteSeek(System.IO.Stream stream)
    {
        if (!stream.CanWrite || !stream.CanSeek)
            throw new NotSupportedException("Cannot build a write-seek stream from a system stream which does not support writing or seeking.");

        return new SystemStreamWrapper(stream);
    }



    public int Read(Span<byte> values)
    {
        return Wrapped.Read(values);
    }

    public void Write(ReadOnlySpan<byte> values)
    {
        Wrapped.Write(values);
    }
}