using System.Runtime.InteropServices;

namespace Lini.Graph.Components;

public readonly struct ComponentRef<T> where T : IComponent
{
    public readonly int Index;

    public ComponentRef(int index)
    {
        Index = index;
    }

    public PlainComponentRef Plain =>
        new(Index, T.TypeID);
}


[StructLayout(LayoutKind.Explicit, Size = sizeof(long))]
public readonly struct PlainComponentRef
{
    // Remember that long is by definition 64 bits
    // and int is, by definition, 32 bits
    // luckily it's not C++


    [FieldOffset(0)]
    public readonly long Full;
    [FieldOffset(0)]
    public readonly int Index;
    [FieldOffset(sizeof(int))]
    public readonly int TypeID;

    public PlainComponentRef(int index, int type)
    {
        Index = index;
        TypeID = type;
    }

    public static PlainComponentRef From<T>(ComponentRef<T> generic) where T : IComponent
        => new(generic.Index, T.TypeID);

    public bool TryTo<T>(out ComponentRef<T> generic) where T : IComponent
    {
        if (Index == T.TypeID)
        {
            generic = new(Index);
            return true;
        }

        generic = default;
        return false;
    }
}