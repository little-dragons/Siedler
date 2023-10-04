namespace Lini.Graph;

public interface IComponent
{
    public void EarlyUpdate(Entity entity, UpdateArgs _)
    {

    }
    public void Update(Entity entity, UpdateArgs _)
    {

    }
    public void LateUpdate(Entity entity, UpdateArgs _)
    {

    }

    public static abstract int Type { get; }
}