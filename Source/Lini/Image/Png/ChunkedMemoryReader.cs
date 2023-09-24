namespace Lini.Image.Png;

/// <summary>
/// A read-only stream that reads its data from provided sections of <see cref="ReadOnlyMemory{byte}"/> which are concatenated.
/// Because writing is therefore not sensical the appropriate methods will therefore throw a <see cref="NotSupportedException"/>.
/// Seeking however is possible and using the <see cref="CutAfter"/> and <see cref="CutBefore"/> methods, slicing is possible.
/// </summary>
public class ChunkedMemoryReader : System.IO.Stream
{
    // General notes: When working with the stream, only modify the 4 non-inherited properties. The other properties
    // inherited from stream are just redirects to those we defined. Because of the chunked memory, we can only
    // ever look at one chunk at the time. This is referred to as the currently active block and that index in the list is
    // stored in a property. The position inside of this block is stored in another variable.
    // Global tracker properties are available, e.g. the cursor location across all blocks as well the total length of 
    // the concatenated blocks.
    // The index shall not go out of bound from the memory list. The stream is at the end if the last index is selected
    // and the cursor inside the block is at the end.




    /// <summary>
    /// A simple buffer for all the provided memories.
    /// </summary>
    private List<ReadOnlyMemory<byte>> MemoryList { get; init; }

    /// <summary>
    /// Stores how many items are there in the fully concatenated list.
    /// </summary>
    private long FullByteCount { get; set; }


    /// <summary>
    /// The current position of the cursor in the currently active instance of the memory.
    /// </summary>
    private int CurrentMemIndex { get; set; }

    /// <summary>
    /// The currently active block of memory.
    /// </summary>
    private int CurrentMemPosition { get; set; }


    /// <summary>
    /// The total position of read bytes independet of the currently active memory block.
    /// </summary>
    private long CurrentBytePosition { get; set; }



    /// <summary>
    /// The full size of the stream in bytes.
    /// </summary>
    public override long Length => FullByteCount;

    /// <summary>
    /// The number of read elements in bytes, but in count of <typeparamref name="T"/>.
    /// </summary>
    public override long Position { get => CurrentBytePosition; set => Seek(value, SeekOrigin.Begin); }


    public ChunkedMemoryReader()
    {
        CurrentMemIndex = 0;
        CurrentMemPosition = 0;
        CurrentBytePosition = 0;
        FullByteCount = 0;
        MemoryList = new();
    }

    public ChunkedMemoryReader(IEnumerable<ReadOnlyMemory<byte>> memories)
        : this()
    {
        foreach (ReadOnlyMemory<byte> memory in memories)
            AddMemory(memory);
    }

    /// <summary>
    /// Adds a new chunk to the memory list at the end. Removing it can not be done easily, refer to the cut methods.
    /// </summary>
    /// <param name="memory">The memory which will be stored as long as this reader is active.</param>
    public void AddMemory(ReadOnlyMemory<byte> memory)
    {
        if (memory.Length == 0)
            return;

        FullByteCount += memory.Length;
        MemoryList.Add(memory);
    }

    /// <summary>
    /// Is true only if the stream still has data to read.
    /// </summary>

    // public override bool CanRead => CurrentBytePosition < FullByteCount;
    public override bool CanRead => true;


    /// <inheritdoc cref="Read(Span{byte})"/>
    public override int Read(byte[] buffer, int offset, int count)
        => Read(new(buffer, offset, count));

    /// <inheritdoc cref="Read(Span{byte})"/>
    public override int Read(Span<byte> bufferSpan)
    {
        if (CurrentMemIndex >= MemoryList.Count)
            return 0;

        // to be set later
        int itemsRead = 0;

        // can still be read
        int length = bufferSpan.Length;

        while (length > 0 && CurrentBytePosition < FullByteCount)
        {
            // read current item to end (if necessary)
            // then maybe repeat and go to next
            ReadOnlyMemory<byte> current = MemoryList[CurrentMemIndex];
            int willBeRead = Math.Min(current.Length - CurrentMemPosition, length);

            // read determined count and write to buffer
            ReadOnlySpan<byte> sourceSpan = current.Span.Slice(CurrentMemPosition, willBeRead);
            Span<byte> targetSpan = bufferSpan.Slice(itemsRead, willBeRead);
            sourceSpan.CopyTo(targetSpan);

            // update read values
            itemsRead += willBeRead;
            length -= willBeRead;

            // advance stream
            CurrentBytePosition += willBeRead;

            // go to next page only if available
            if (CurrentMemPosition + willBeRead >= current.Length && CurrentMemIndex < MemoryList.Count)
            {
                CurrentMemPosition = 0;
                CurrentMemIndex++;
            }
            else
            {
                CurrentMemPosition += willBeRead;
            }
        }


        return itemsRead;
    }


    public override bool CanSeek => true;

    /// <summary>
    /// Sets the cursor of the stream to a given byte value.
    /// </summary>
    /// <param name="offset">The offset in bytes from the origin. Can be negative</param>
    /// <param name="origin">The origin of the stream.</param>
    /// <returns>The new position of the cursor. The old position is returned if there was an error (or this location was requested).</returns>
    public override long Seek(long offset, SeekOrigin origin)
    {
        long aim = 0;
        if (origin is SeekOrigin.Begin)
        {
            if (offset < 0 || offset > FullByteCount)
                return CurrentBytePosition;

            aim = offset;
        }
        else if (origin is SeekOrigin.End)
        {
            if (offset > 0 || offset < -FullByteCount)
                return CurrentBytePosition;

            aim = FullByteCount - offset;
        }
        else
        {
            if (offset < CurrentBytePosition || offset >= FullByteCount - CurrentBytePosition)
                return CurrentBytePosition;

            aim = CurrentBytePosition + offset;
        }

        // go back if there is still the possibility to go back.
        while (aim < CurrentBytePosition && !(CurrentMemIndex <= 0 && CurrentMemPosition <= 0))
        {
            // go back through current memory
            ReadOnlyMemory<byte> current = MemoryList[CurrentMemIndex];


            // as far as is needed but not more than possible in this block
            int toGo = Math.Min(CurrentMemPosition, (int)(CurrentBytePosition - aim));
            CurrentMemPosition -= toGo;
            CurrentBytePosition -= toGo;


            // we have to go to the next block if available and needed
            if (CurrentBytePosition != aim && CurrentMemIndex > 0)
            {
                CurrentMemIndex--;
                CurrentMemPosition = MemoryList[CurrentMemIndex].Length;
            }
        }

        // go forward if we can go forward
        while (aim > CurrentBytePosition && CurrentBytePosition < FullByteCount)
        {
            ReadOnlyMemory<byte> current = MemoryList[CurrentMemIndex];

            // go as far as possible and needed
            int toGo = Math.Min(current.Length - CurrentMemPosition, (int)(aim - CurrentBytePosition));
            CurrentMemPosition += toGo;
            CurrentBytePosition += toGo;

            // we have to go to the next block if available and needed
            if (CurrentBytePosition != aim && CurrentMemIndex < MemoryList.Count - 1)
            {
                CurrentMemIndex++;
                CurrentMemPosition = 0;
            }
        }

        return CurrentBytePosition;
    }


    /// <summary>
    /// Slices this stream so that the current reader is at the beginning and the memory in front is no longer accessible.
    /// </summary>
    /// <returns>The number of bytes cut.</returns>
    public int CutBefore()
    {
        // count how many items were cut
        int count = 0;
        for (int i = 0; i < CurrentMemIndex; i++)
            count += MemoryList[i].Length;

        // cut all non active memories from the list
        MemoryList.RemoveRange(0, CurrentMemIndex);
        CurrentMemIndex = 0;

        // slice current memory
        MemoryList[0] = MemoryList[0].Slice(CurrentMemPosition);
        count += CurrentMemPosition;
        CurrentMemPosition = 0;

        // adjust counts
        FullByteCount -= count;
        CurrentBytePosition = 0;


        return count;
    }


    /// <summary>
    /// Slices this stream so that the current reader is at the end. Memory after the current cursor position is no longer accessible.
    /// </summary>
    /// <returns>The number of bytes cut.</returns>
    public int CutAfter()
    {
        // count how many items were cut
        int count = 0;
        for (int i = CurrentMemIndex + 1; i < MemoryList.Count; i++)
            count += MemoryList[i].Length;

        // cut unused memory blocks
        MemoryList.RemoveRange(CurrentMemIndex + 1, MemoryList.Count - CurrentMemIndex - 1);

        // slice current memory
        count += MemoryList[CurrentMemIndex].Length - CurrentMemPosition;
        MemoryList[CurrentMemIndex] = MemoryList[CurrentMemIndex].Slice(0, CurrentMemPosition);


        // adjust count
        FullByteCount -= count;

        return count;
    }







    // methods that need to be implemented for stream.
    // it seems to be common practice to throw if this is a read-only stream.

    /// <summary>
    /// Since you can't write, flushing makes no sonse. Will throw.
    /// </summary>
    /// <exception cref="NotSupportedException"/>
    public override void Flush() =>
        throw new NotSupportedException();

    /// <summary>
    /// Cannot set a specific length. The length is inferred from the submitted memory blocks.
    /// </summary>
    /// <exception cref="NotSupportedException"/>
    public override void SetLength(long value) =>
        throw new NotSupportedException();

    /// <summary>
    /// Cannot write to a chunked memory reader. You are free to write to memory yourself and submit it to the chunk.
    /// </summary>
    /// <exception cref="NotSupportedException"/>
    public override void Write(byte[] buffer, int offset, int count) =>
        throw new NotSupportedException();

    /// <summary>
    /// Always is false. You can't write to a chunked memory reader.
    /// </summary>
    public override bool CanWrite => false;
}