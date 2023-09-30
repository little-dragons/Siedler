namespace Lini.Stream;

public class SignatureStream<T> : IReadSeekStream<T, T>
{
    private IReadSeekStream<T, T> Source { get; init; }
    public int HeaderLength { get; private init; }
    public int FooterLength { get; private init; }

    public long Length => Source.Length - HeaderLength - FooterLength;
    public long Position => Source.Position - HeaderLength;

    public SignatureStream(IReadSeekStream<T, T> source, int headerLength = 0, int footerLength = 0)
    {
        HeaderLength = headerLength;
        FooterLength = footerLength;
        Source = source;
        Seek(0);
    }

    /// <summary>
    /// Gets the header of the stream.
    /// </summary>
    /// <param name="header">The span to write the header into. If the supplied span has a longer length 
    /// than defined in <see cref="HeaderLength"/>, the end is cut to only write that many elements at most.</param>
    public void GetHeader(Span<T> header)
    {
        if (header.Length > HeaderLength)
            header = header[..HeaderLength];

        long cached = Source.Position;

        Source.Seek(0);
        Source.Read(header);

        Source.Seek(cached);
    }

    /// <summary>
    /// Gets the footer of the stream. Note that this property is dependent on the length of the supplied source stream at the current time.
    /// </summary>
    /// <param name="footer">The span to write the footer into. If the supplied span has a longer length 
    /// than defined in <see cref="FooterLength"/>, the end is cut to only write that many elements at most.</param>
    public void GetFooter(Span<T> footer)
    {
        if (footer.Length > FooterLength)
            footer = footer[..FooterLength];

        long cached = Source.Position;

        Source.SeekEnd(FooterLength);
        Source.Read(footer);

        Source.Seek(cached);
    }

    public int Read(Span<T> values)
    {
        // it is vital for good style to make sure that
        // the header and footer are not read in this method

        // do not read header
        if (Position < 0)
            Seek(0);

        // do not read footer
        if (Position + values.Length > Length)
            values = values[..(int)(Length - Position)];

        return Source.Read(values);
    }

    public void Seek(long value)
        => Source.Seek(HeaderLength + value);
}