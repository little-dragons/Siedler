namespace Lini.Stream;

public interface IWriteStream<T> where T : unmanaged
{
    public void Write(ReadOnlySpan<T> values);
}