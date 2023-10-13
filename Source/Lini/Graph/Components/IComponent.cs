namespace Lini.Graph.Components;

public interface IComponent
{
    public void EarlyUpdate(UpdateArgs _)
    {

    }
    public void Update(UpdateArgs _)
    {

    }
    public void LateUpdate(UpdateArgs _)
    {

    }

    public Entity Entity { get; set; }

    public static abstract int TypeID { get; set; }
}