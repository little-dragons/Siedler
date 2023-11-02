namespace Lini.Stream;

public interface IReadStream<T>
{
    /// <summary>
    /// Reads from a stream and tries to fill the span. It advances the stream by doing so.
    /// Note that the stream might reach its end or simply return early before filling the entire span.
    /// However, a stream implementation may not return zero bytes if there is still data.
    /// Returning no data is equivalent to the stream being unable to read further data.
    /// </summary>
    /// <param name="values">The span to be filled with values from the stream.</param>
    /// <returns>The number of elements actually written.</returns>
    public int Read(Span<T> values);

    /// <summary>
    /// Reads all elements of this stream and writes them into <paramref name="write"/>. It uses a buffer mechanism
    /// to achieve that.
    /// </summary>
    /// <param name="write">A write stream which receives the entries of this stream.</param>
    /// <param name="bufferSize">Determines the size of the blocks used for buffering. The default value is stolen
    /// from the standard library. The rationale is: It is small enough to avoid the large object hea, but still is 
    /// a multiple of 4096. Having a large buffer is also no problem since it will most probably not survive garbage collection 
    /// for a long time.</param>
    public void CopyTo(IWriteStream<T> write, int bufferSize = 81920)
    {
        T[] arr = new T[bufferSize];
        var span = new Span<T>(arr);
        while (true)
        {
            int read = Read(span);
            if (read != 0)
                write.Write(span[..read]);

            if (read == 0)
                return;
        }
    }
}
