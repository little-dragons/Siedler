namespace Lini.Graph;

internal sealed class ComponentList
{
    /// <summary>
    /// Maps the type of an unmanaged type to its index 
    /// </summary>
    private Dictionary<int, int> TypeMapping { get; init; } = new();

    private List<object> Components { get; init; } = new();

    public IReadOnlyList<T> GetAll<T>() where T : IComponent
        => (Components[TypeMapping[T.Type]] as IReadOnlyList<T>)!;

    public T Get<T>(ComponentRef<T> component) {
        TypeMapping[component.Type]
    }

}