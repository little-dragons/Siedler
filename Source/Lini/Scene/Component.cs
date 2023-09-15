namespace Lini.Scene;

public abstract class Component
{
    public Entity? Entity { get; private set; }

    internal void RegisterFor(Entity newOwner)
    {
        Entity = newOwner;
    }

    internal void Deregister()
    {
        Entity = null;
    }


    public virtual void EarlyUpdate(UpdateArgs _)
    {

    }
    public virtual void Update(UpdateArgs _)
    {

    }
    public virtual void LateUpdate(UpdateArgs _)
    {

    }

    public virtual void Render(RenderArgs _)
    {

    }
}