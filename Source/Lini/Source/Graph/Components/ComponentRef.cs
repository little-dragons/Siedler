using System.Diagnostics.CodeAnalysis;

namespace Lini.Graph.Components;

public readonly record struct ComponentRef<T>(int Index) where T : struct, IComponent
{
    public PlainComponentRef Plain =>
        new(Index, T.TypeID);
}



public readonly record struct PlainComponentRef(int Index, int TypeID)
{
    public bool TryTo<T>([NotNullWhen(true)] out ComponentRef<T>? generic) where T : struct, IComponent
    {
        if (Index == T.TypeID)
        {
            generic = new(Index);
            return true;
        }

        generic = null;
        return false;
    }
}