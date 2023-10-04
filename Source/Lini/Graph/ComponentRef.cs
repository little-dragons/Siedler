using System.Runtime.InteropServices;

namespace Lini.Graph;

public readonly struct ComponentRef<T> where T : IComponent
{
    public readonly int Index;

    public ComponentRef(int index)
    {
        Index = index;
    }
}


[StructLayout(LayoutKind.Explicit, Size = 8)]
public readonly struct PlainComponentRef
{
    // Remember that long is by definition 64 bits
    // and int is, by definition, 32 bits


    [FieldOffset(0)]
    public readonly long Full;
    [FieldOffset(0)]
    public readonly int Index;
    [FieldOffset(4)]
    public readonly int Type;

    public PlainComponentRef(int index, int type)
    {
        Index = index;
        Type = type;
    }

    public static PlainComponentRef From<T>(ComponentRef<T> generic) where T : IComponent
        => new(generic.Index, T.Type);

    public bool TryTo<T>(out ComponentRef<T> generic) where T : IComponent
    {
        if (Index == T.Type)
        {
            generic = new(Index);
            return true;
        }

        generic = new(-1);
        return false;
    }
}