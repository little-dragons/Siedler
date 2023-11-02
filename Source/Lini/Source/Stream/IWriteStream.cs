namespace Lini.Stream;

public interface IWriteStream<T>
{
    public void Write(ReadOnlySpan<T> values);
    public void Write(T value)
    {
        Write(new Span<T>(ref value));
    }
}