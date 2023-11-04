namespace Lini.Graph.Components;


/// <summary>
/// A component may be attached to an <see cref="Entity"/> and is the most basic
/// updatable unit in the scene graph. Entities itself cannot be updated.
/// </summary>
public interface IComponent
{
    public static abstract int TypeID { get; set; }

    
    public void EarlyUpdate(UpdateArgs _)
    {

    }
    public void Update(UpdateArgs _)
    {

    }
    public void LateUpdate(UpdateArgs _)
    {

    }
}