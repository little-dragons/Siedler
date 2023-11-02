namespace Lini.Stream;

public interface ISeekStream<T>
{
    public long Length { get; }
    public long Position { get; }

    public void Seek(long value);
    
    public void SeekEnd(long value)
        => Seek(Length - value);

    public void SeekOffset(long value)
        => Seek(Position + value);
}