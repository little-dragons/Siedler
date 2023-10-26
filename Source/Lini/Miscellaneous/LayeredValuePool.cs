namespace Lini.Miscellaneous;

/// <summary>
/// This pool is supposed to keep cache coherency among a large number of value-types.
/// Since construction and deletion of value types is trivial, it is not the primary concern of this pool,
/// instead it tries to keep the buffer with the stored objects as tightly packed as possible.
/// </summary>
/// <typeparam name="T"></typeparam>
public class LayeredValuePool<T> where T : struct
{
    private const int ElementsPerLayer = 256;

    private List<T[]> Layers { get; init; }
    private int LastLayerCount { get; set; }

    private Stack<ValueTuple<int, int>> Holes { get; init; }

    public int Capacity => Layers.Capacity * ElementsPerLayer;
    public int Count => Layers.Count == 0 ? 0 : (Layers.Count - 1) * ElementsPerLayer + LastLayerCount;

    public LayeredValuePool(int initCapacity)
    {
        Layers = new(Math.Max(initCapacity / ElementsPerLayer, 1)) {
            new T[ElementsPerLayer],
        };
        Holes = new();
    }

    public int Retrieve(in T item)
    {
        // first, try to fill holes
        while (Holes.TryPop(out var tup))
        {
            var (layer, idx) = tup;

            // skip those "holes" which are no longer holes
            // the holes it points to are actually no longer holds, because the cache holds fewer
            // elements. Filling those holes breaks coherency with the last layer.
            if (layer >= Layers.Count || layer == Layers.Count - 1 && idx >= LastLayerCount)
                continue;
            else
                return layer * ElementsPerLayer + idx;
        }

        // there is still room in this layer
        if (LastLayerCount < ElementsPerLayer)
            return (Layers.Count - 1) * ElementsPerLayer + LastLayerCount++;

        // another layer needs to be added
        Layers.Add(new T[ElementsPerLayer]);
        Layers[^1][0] = item;
        LastLayerCount = 1;

        return (Layers.Count - 1) * ElementsPerLayer;
    }

    public int Retrieve()
        => Retrieve(default);

    public ref T this[int index]
    {
        get
        {
            if (index < 0 || index > Count)
                throw new ArgumentOutOfRangeException($"{nameof(index)} is out of range.");

            int partIndex = index % ElementsPerLayer;
            int layerIndex = index / ElementsPerLayer;

            return ref Layers[layerIndex][partIndex];
        }
    }

    public void DoForAll(RefAction<T> action)
    {
        // The problem with this method is that the holes need to be considered.
        // Since this layer is designed to hold more than a thousand elements,
        // iteration speed is decisive. Adding an if check to each element seems
        // slow, it's probably faster to have a for loop which considers the holes
        // and then iterates undisturbed between each hole.

        var sortedHoles = new (int, int)[Holes.Count];
        Holes.CopyTo(sortedHoles, 0);
        Array.Sort(sortedHoles);

        int lastHole = -1;
        foreach (int hole in sortedHoles)
        {
            for (int i = lastHole + 1; i < hole; i++)
                action(Items[i]);

            lastHole = hole;
        }

        for (int i = lastHole + 1; i < Items.Count; i++)
            action(Items[i]);

        for (int i = 0; i < Layers.Count; i++)
            for (int j = 0; j < ElementsPerLayer; j++)
                action(ref Layers[i][j]);
    }

    /// <summary>
    /// This method exists because it is easier to call by reflection
    /// than <see cref="DoForAll(RefAction{T})"/>.
    /// </summary>
    /// <param name="d">The delegate which must be a <see cref="RefAction{T}"/>.</param>
    internal void DoForAllDelegate(Delegate d)
    {
        DoForAll((RefAction<T>)d);
    }


    public void Return(int index)
    {
        if (index < 0 || index > Count)
            throw new ArgumentOutOfRangeException($"{nameof(index)} is out of range.");

        int partIndex = index % Layer.ELEMENTS;
        int layerIndex = index / Layer.ELEMENTS;

        if (Count == 1 || index == Count - 1)
            Layers[layerIndex].Free(partIndex);
        else
        {
            ref T last = ref Layers[^1][Layers[^1].Count - 1];
            Layers[layerIndex].Replace(in last, partIndex);
            Layers[^1].Free(Layers[^1].Count - 1);
        }

        while (Layers.Count > 0 && Layers[^1].Count == 0)
            Layers.RemoveAt(Layers.Count - 1);
    }
}