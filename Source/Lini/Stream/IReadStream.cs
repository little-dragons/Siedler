namespace Lini.Stream;

public interface IReadStream<T> where T : unmanaged
{
    /// <summary>
    /// Reads from a stream and tries to fill the span. It advances the stream by doing so.
    /// Note that the stream might reach its end before filling the span. Check the return value.
    /// </summary>
    /// <param name="values">The span to be filled with values from the stream.</param>
    /// <returns>The number of elements actually written.</returns>
    public int Read(Span<T> values);
}