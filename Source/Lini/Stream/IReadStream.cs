using System.Runtime.CompilerServices;

namespace Lini.Stream;

public interface IReadStream<T>
{
    /// <summary>
    /// Reads from a stream and tries to fill the span. It advances the stream by doing so.
    /// Note that the stream might reach its end before filling the span. Check the return value.
    /// </summary>
    /// <param name="values">The span to be filled with values from the stream.</param>
    /// <returns>The number of elements actually written.</returns>
    public int Read(Span<T> values);

    public void CopyTo(IWriteStream<T> write)
    {
        int bufferSize = 81920;
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
