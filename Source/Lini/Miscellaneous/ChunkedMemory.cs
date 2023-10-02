namespace Lini.Miscellaneous;

/// <summary>
/// This class is not correctly implemented. It is only an idea to abstract the <see cref="Stream.ChunkedMemoryStream"/>,
/// because this class currently violates the single responisibility prinicple.
/// </summary>
/// <typeparam name="T"></typeparam>
[Obsolete(@"This class is not correctly implemented. It is only an idea to abstract the ChunkedMemoryStream.
It should also be public.")]
internal readonly struct ChunkedMemory<T>
{
    /// <summary>
    /// This here is the problematic field.
    /// You would need to heap allocate an array for each single instance of chunked memory,
    /// making it not very efficient. If you slice the <see cref="ChunkedMemory{T}"/>, you would potentially need
    /// to also slice single elements of this segment, which you means you need to modify the array, and
    /// this would also change all other <see cref="ChunkedMemory{T}"/> instances over the same segment, thus you need to copy
    /// the segment and all of its contents, thus requiring space and this space is heap allocated. It is still unsolved
    /// to provide a slice algorithm without dynamic heap allocations.
    /// </summary>
    public readonly ArraySegment<Memory<T>> Chunks;
    public readonly int Count;

    public ChunkedMemory()
    {
        Chunks = new();
        Count = 0;
    }

    public ChunkedMemory(ArraySegment<Memory<T>> chunks)
    {
        Chunks = chunks;

        Count = 0;
        foreach (var chunk in Chunks)
            Count += chunk.Length;
    }

    public struct Position
    {
        public int ChunkIndex;
        public int MemoryIndex;
    }


    public Position PositionOf(int overallIndex)
    {
        if (overallIndex >= Count || overallIndex < 0)
            return new()
            {
                ChunkIndex = -1,
                MemoryIndex = -1,
            };

        Position position = new();

        foreach (var chunk in Chunks)
        {
            if (overallIndex > chunk.Length)
            {
                overallIndex -= chunk.Length;
                position.ChunkIndex++;
                continue;
            }
            else
            {
                position.MemoryIndex = overallIndex;
                return position;
            }
        }


        position.ChunkIndex = -1;
        position.MemoryIndex = -1;
        return position;
    }
    public Position PositionOfEnd(int endIndex)
    {
        if (endIndex >= Count || endIndex < 0)
            return new()
            {
                ChunkIndex = -1,
                MemoryIndex = -1,
            };

        Position position = new()
        {
            MemoryIndex = Chunks.Count - 1
        };

        for (int i = Chunks.Count - 1; i >= 0; i--)
        {
            var chunk = Chunks[i];
            if (endIndex > chunk.Length)
            {
                endIndex -= chunk.Length;
                position.ChunkIndex--;
                continue;
            }
            else
            {
                position.MemoryIndex = chunk.Length - endIndex;
                return position;
            }
        }

        position.ChunkIndex = -1;
        position.MemoryIndex = -1;
        return position;
    }

    public Position PositionOf(Index index)
    {
        if (index.IsFromEnd)
            return PositionOfEnd(index.Value);
        else
            return PositionOf(index.Value);
    }


    public ChunkedMemory<T> Slice(Range range)
    {
        var start = PositionOf(range.Start);
        var end = PositionOf(range.End);

        return new(Chunks[start.ChunkIndex..end.ChunkIndex]);
    }
}