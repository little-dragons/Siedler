
namespace Lini.Stream;

public class LiniStreamWrapper : System.IO.Stream
{
    public override bool CanRead => IsRead;

    public override bool CanSeek => IsSeek;

    public override bool CanWrite => IsWrite;

    public override long Length => IsSeek ? ((ISeekStream<byte>)LiniStream).Length : throw new NotSupportedException();

    public override long Position
    {
        get
        {
            if (IsSeek)
                return ((ISeekStream<byte>)LiniStream).Position;
            else
                throw new NotSupportedException();
        }
        set
        {
            if (IsSeek)
                ((ISeekStream<byte>)LiniStream).Seek(value);
            else
                throw new NotSupportedException();
        }
    }

    private readonly object LiniStream;
    private readonly bool IsRead;
    private readonly bool IsWrite;
    private readonly bool IsSeek;

    private LiniStreamWrapper(object liniStream, bool isRead, bool isWrite, bool isSeek)
    {
        LiniStream = liniStream;
        IsRead = isRead;
        IsWrite = isWrite;
        IsSeek = isSeek;
    }

    public static LiniStreamWrapper WrapRead(IReadStream<byte> stream)
        => new(stream, true, false, false);
    public static LiniStreamWrapper WrapWrite(IWriteStream<byte> stream)
        => new(stream, false, true, false);
    public static LiniStreamWrapper WrapSeek(ISeekStream<byte> stream)
        => new(stream, false, false, true);
    public static LiniStreamWrapper WrapReadSeek(IReadSeekStream<byte, byte> stream)
        => new(stream, true, false, true);
    public static LiniStreamWrapper WrapReadWrite(IReadWriteStream<byte, byte> stream)
        => new(stream, true, true, false);
    public static LiniStreamWrapper WrapWriteSeek(IWriteSeekStream<byte, byte> stream)
        => new(stream, false, true, true);
    public static LiniStreamWrapper WrapReadWriteSeek(IReadWriteSeekStream<byte, byte, byte> stream)
        => new(stream, true, true, true);

    public override void Flush()
    {
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        if (IsRead)
            return ((IReadStream<byte>)LiniStream).Read(new Span<byte>(buffer, offset, count));
        else
            throw new NotSupportedException();
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        if (!IsSeek)
            throw new NotSupportedException();

        var str = (ISeekStream<byte>)LiniStream;
        if (origin == SeekOrigin.Begin)
            str.Seek(offset);
        if (origin == SeekOrigin.Current)
            str.SeekOffset(offset);
        if (origin == SeekOrigin.End)
            str.SeekEnd(offset);

        return str.Position;
    }

    public override void SetLength(long value)
    {
        throw new NotSupportedException();
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        if (IsWrite)
            ((IWriteStream<byte>)LiniStream).Write(new Span<byte>(buffer, offset, count));
        else
            throw new NotSupportedException();
    }
}