using System.Runtime.CompilerServices;

namespace Lini.Miscellaneous;

/// <summary>
/// This pool is supposed to keep cache coherency among a large number of value-types.
/// Since construction and deletion of value types is trivial, it is not the primary concern of this pool,
/// instead it tries to keep the buffer with the stored objects as tightly packed as possible.
/// It also aims to provide references to the items and not relocate them any more than the garbage collector.
/// 
/// The main concern of this class is speed: Since this is just a wrapper for an array in the end,
/// it should not perform significantly worse, in the opposite, for the designed usecase, it should
/// actually be faster. This leads to some problems, because it does not simply wrap an array, but
/// also allows users to return the used elements. This increases the complexity significantly.
/// Some disadvantages have to be incorporated. The goal is: Have a fast <see cref="Retrieve()"/> and a fast 
/// <see cref="DoForAll(RefAction{T})"/>. The <see cref="Return(int)"/> should be of moderate speed.
/// </summary>
/// <typeparam name="T">Some value type.</typeparam>
public class LayeredValuePool<T> where T : struct
{

    private const int ElementsPerLayer = 256;

    /// <summary>
    /// This list should only contain arrays which are actually used. Of course the arrays itself should 
    /// only be of length <see cref="ElementsPerLayer"/>.
    /// </summary>
    private List<T[]> Layers { get; init; }

    /// <summary>
    /// The length of the last layer: If no layer is used, this should be equal to <see cref="ElementsPerLayer"/>.
    /// </summary>
    private int LastLayerCount { get; set; }

    /// <summary>
    /// A list of holes as indices into this data structure. The items contained in holes must never be 
    /// outside of the actual used indices at any given time: This enables faster fetching from this list,
    /// but increases computational load for return. This is a tradeoff in line with the overall design of 
    /// this class.
    /// </summary>
    private SortedSet<int> Holes { get; init; }



    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static (int, int) ResolveIndex(int index)
        => (index / ElementsPerLayer, index % ElementsPerLayer);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int MakeIndex(int layer, int index)
        => layer * ElementsPerLayer + index;


    public int Count => (Layers.Count - 1) * ElementsPerLayer + LastLayerCount - Holes.Count;


    public LayeredValuePool()
    {
        Layers = new();
        Holes = new();
        Clear();
    }

    public int Retrieve(in T item)
    {
        // TODO: item assignment
        // first, try to fill holes
        if (Holes.Any())
        {
            int x = Holes.Min;
            Holes.Remove(x);
            return x;
        }

        // there is still room in this layer
        if (LastLayerCount < ElementsPerLayer)
            return MakeIndex(Layers.Count - 1, LastLayerCount++);

        // another layer needs to be added
        Layers.Add(new T[ElementsPerLayer]);
        Layers[^1][0] = item;
        LastLayerCount = 1;

        return MakeIndex(Layers.Count - 1, 0);
    }

    public int Retrieve()
        => Retrieve(default);

    public ref T this[int index]
    {
        get
        {
            var (layerIndex, partIndex) = ResolveIndex(index);
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

        var sortedHoles = new int[Holes.Count + 1];
        Holes.CopyTo(sortedHoles);
        sortedHoles[^1] = Count;


        int lastLayer = -1;
        int lastIndex = ElementsPerLayer;
        foreach (int hole in sortedHoles)
        {
            var (nextLayer, nextIndex) = ResolveIndex(hole);

            for (; lastLayer < nextLayer; lastLayer++)
            {
                for (; lastIndex < ElementsPerLayer; lastIndex++)
                    action(ref Layers[lastLayer][lastIndex]);

                lastIndex = 0;
            }

            for (; lastIndex < nextIndex; lastIndex++)
                action(ref Layers[nextLayer][lastIndex]);
        }
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
        // There are some options for return:
        // - either it always adds a hole: this works, but in practice completely disables shrinking behaviour:
        //        Holes.Add(index);
        // 
        // - or it actually tries to cleanup the data structure. It has to check which element is the last in use
        //   and clean up everything after it. This only is done if the returned index is either the last or the 
        //   first item. Otherwise it cannot cleanup anything regardless. We will not consider cleaning up the
        //   beginning of the layers, only the end.

        // we choose the second option


        if (index == Count - 1)
        {
            if (Holes.Contains(index - 1))
            {
                int newLastElementIndex = index - 2;
                while (Holes.Contains(newLastElementIndex) && newLastElementIndex >= 0)
                {
                    // because we will skip those holes anyway
                    Holes.Remove(newLastElementIndex);
                    newLastElementIndex--;
                }

                // there are no elements in this pool
                if (newLastElementIndex < 0)
                {
                    Layers.Clear();
                    Holes.Clear();
                    LastLayerCount = ElementsPerLayer;
                    return;
                }

                // everything between this value and the current last value is a hole and should be removed.
                var (newLastLayer, newLastIdx) = ResolveIndex(newLastElementIndex);

                for (int i = Layers.Count - 1; i > newLastLayer; i--)
                    Layers.RemoveAt(i);

                LastLayerCount = newLastIdx + 1;
            }
            else
            {
                if (LastLayerCount == 1)
                {
                    LastLayerCount = ElementsPerLayer;
                    Layers.RemoveAt(Layers.Count - 1);
                }
                else
                {
                    LastLayerCount--;
                }
            }
        }
        else
        {
            Holes.Add(index);
        }
    }

    public void Clear()
    {
        Layers.Clear();
        Holes.Clear();
        LastLayerCount = ElementsPerLayer;
    }
}