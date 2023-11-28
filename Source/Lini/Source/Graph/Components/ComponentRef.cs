using System.Runtime.InteropServices;

namespace Lini.Graph.Components;

public readonly struct ComponentRef<T>(int index) where T : struct, IComponent
{
    public readonly int Index = index;

    public PlainComponentRef Plain =>
        new(Index, T.TypeID);
}


[StructLayout(LayoutKind.Explicit, Size = sizeof(long))]
public readonly struct PlainComponentRef(int index, int type)
{
    // Remember that long is by definition 64 bits
    // and int is, by definition, 32 bits
    // luckily it's not C++


    [FieldOffset(0)]
    public readonly long Full;
    [FieldOffset(0)]
    public readonly int Index = index;
    [FieldOffset(sizeof(int))]
    public readonly int TypeID = type;

    public bool TryTo<T>(out ComponentRef<T> generic) where T : struct, IComponent
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