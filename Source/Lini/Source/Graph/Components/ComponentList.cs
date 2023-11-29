using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Lini.Graph.Components;


public struct ComponentList
{
    public const int MAX_ELEMENTS = 16;

    [InlineArray(MAX_ELEMENTS)]
    private struct FixedSizeArray
    {
        private PlainComponentRef _;
    }

    // inits to 0
    public int Count { get; private set; }
    private FixedSizeArray Array;

    public PlainComponentRef this[int index]
        => Array[index];

    public bool TryAdd(PlainComponentRef comp)
    {
        if (Count >= MAX_ELEMENTS)
            return false;

        Array[Count] = comp;
        Count++;
        return true;
    }

    public readonly bool TryGet<T>([NotNullWhen(true)] out ComponentRef<T>? comp) where T : struct, IComponent
    {
        foreach (var stored in Array[..Count])
        {
            if (stored.TryTo(out comp))
                return true;
        }

        comp = null;
        return false;
    }

    public void Free(PlainComponentRef comp)
    {
        for (int i = 0; i < Count; i++)
            if (Array[i] == comp)
            {
                // copy the last element to the deleted element
                // if i is equal to that value, this has no effect and is a very
                // fast operation and may be still be done to omit the condition
                Array[i] = Array[Count - 1];

                Count--;
                return;
            }
    }

    

    public readonly IEnumerator<PlainComponentRef> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
            yield return Array[i];
    }
}