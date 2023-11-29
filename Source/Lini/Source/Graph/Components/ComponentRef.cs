namespace Lini.Graph.Components;

public readonly record struct ComponentRef<T>(int Index) where T : struct, IComponent
{
    public PlainComponentRef Plain =>
        new(Index, T.TypeID);
}



public readonly record struct PlainComponentRef(int Index, int TypeID)
{
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