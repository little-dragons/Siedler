namespace Lini.Stream;


/// <summary>
/// A stream for writing, reading and seeking in a memory object. It is fixed,
/// because it only uses a single memory object and the object storage cannot be expanded
/// or increased in anyway, it can only access the initially given memory.
/// </summary>
/// <typeparam name="T"></typeparam>
public class FixedMemoryStream<T> : IReadWriteSeekStream<T, T, T>
{
    private Memory<T> Store { get; init; }
    public FixedMemoryStream(Memory<T> memory)
    {
        Store = memory;
    }
    public FixedMemoryStream(T[] array)
    {
        Store = new Memory<T>(array);
    }

    public long Length => Store.Length;

    public long Position { get; private set; }

    public int Read(Span<T> values)
    {
        long itemsToRead = Math.Min(values.Length, Store.Length - Position);
        var storePart = Store[(int)Position..(int)(Position + itemsToRead)];
        storePart.Span.CopyTo(values);
        Position += itemsToRead;
        return (int)itemsToRead;
    }

    public void Write(ReadOnlySpan<T> values)
    {
        long itemsToWrite = Math.Min(values.Length, Store.Length - Position);
        values.CopyTo(Store[(int)Position..(int)(Position + itemsToWrite)].Span);
        Position += itemsToWrite;
    }

    public void Seek(long value)
    {
        Position = value;
    }
}
