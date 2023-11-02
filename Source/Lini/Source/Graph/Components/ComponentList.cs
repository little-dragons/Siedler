using System.Runtime.InteropServices;

namespace Lini.Graph.Components;


[StructLayout(LayoutKind.Sequential)]
// TODO: use inline arrays when .NET 8 is released
// [System.Runtime.CompilerServices.InlineArray(COUNT)]
public struct ComponentList
{
    public const int MAX_ELEMENTS = 16;

    // inits to 0
    private int Count;

    private PlainComponentRef Ref0;
    private PlainComponentRef Ref1;
    private PlainComponentRef Ref2;
    private PlainComponentRef Ref3;
    private PlainComponentRef Ref4;
    private PlainComponentRef Ref5;
    private PlainComponentRef Ref6;
    private PlainComponentRef Ref7;
    private PlainComponentRef Ref8;
    private PlainComponentRef Ref9;
    private PlainComponentRef Ref10;
    private PlainComponentRef Ref11;
    private PlainComponentRef Ref12;
    private PlainComponentRef Ref13;
    private PlainComponentRef Ref14;
    private PlainComponentRef Ref15;

    private Span<PlainComponentRef> FullSpan()
        => MemoryMarshal.CreateSpan(ref Ref0, MAX_ELEMENTS);

    public Span<PlainComponentRef> AsSpan()
        => MemoryMarshal.CreateSpan(ref Ref0, Count);

    public ReadOnlySpan<PlainComponentRef> AsReadOnlySpan()
        => MemoryMarshal.CreateReadOnlySpan(ref Ref0, Count);

    public bool TryAdd(PlainComponentRef comp)
    {
        if (Count >= MAX_ELEMENTS)
            return false;

        FullSpan()[Count] = comp;
        Count++;
        return true;
    }

    public bool TryGet<T>(out ComponentRef<T> comp) where T : IComponent
    {
        foreach (var stored in AsReadOnlySpan())
        {
            if (stored.TryTo(out comp))
                return true;
        }

        comp = default;
        return false;
    }

    public void Free(PlainComponentRef comp)
    {
        var span = FullSpan();
        for (int i = 0; i < Count; i++)
            if (span[i].Full == comp.Full)
            {
                // copy the last element to the deleted element
                // if i is equal to that value, this has no effect and is a very
                // fast operation and may be still be done to omit the condition
                span[i] = span[Count - 1];

                Count--;
                return;
            }
    }
}