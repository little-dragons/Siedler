namespace Lini.Stream;

public class ChunkedMemoryStream : IReadSeekStream<byte, byte>
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

    public long Position => CurrentBytePosition;
    public long Length => FullByteCount;

    public ChunkedMemoryStream()
    {
        CurrentMemIndex = 0;
        CurrentMemPosition = 0;
        CurrentBytePosition = 0;
        FullByteCount = 0;
        MemoryList = new();
    }

    public ChunkedMemoryStream(IEnumerable<ReadOnlyMemory<byte>> memories)
        : this()
    {
        foreach (ReadOnlyMemory<byte> memory in memories)
            Append(memory);
    }

    public void Append(ReadOnlyMemory<byte> memory)
    {
        if (memory.Length == 0)
            return;

        FullByteCount += memory.Length;
        MemoryList.Add(memory);
    }



    public int Read(Span<byte> bufferSpan)
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



    public void Seek(long aim)
    {
        if (aim < 0 || aim > FullByteCount)
            return;


        // go back if there is still the possibility to go back.
        while (aim < CurrentBytePosition && !(CurrentMemIndex <= 0 && CurrentMemPosition <= 0))
        {
            // go back through current memory
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

        return;
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
        MemoryList[CurrentMemIndex] = MemoryList[CurrentMemIndex][..CurrentMemPosition];


        // adjust count
        FullByteCount -= count;

        return count;
    }
}