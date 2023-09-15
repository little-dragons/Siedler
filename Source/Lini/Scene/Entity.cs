namespace Lini.Scene;

public class Entity
{
    public List<Component> Components { get; init; } = new();

    public bool Enabled { get; set; }

    public void WriteComponent<T>(T component) where T : Component
    {
        component.RegisterFor(this);

        for (int i = 0; i < Components.Count; i++)
        {
            if (Components[i] is T)
            {
                Components[i].Deregister();
                Components[i] = component;
                return;
            }
        }

        Components.Add(component);
    }

    public void RemoveComponent<T>() where T : Component
    {
        for (int i = 0; i < Components.Count; i++)
        {
            if (Components[i] is T)
            {
                Components[i].Deregister();
                Components.RemoveAt(i);
                return;
            }
        }
    }

    public T? ReadComponent<T>() where T : Component
    {
        foreach (var comp in Components)
        {
            if (comp is T)
                return comp as T;
        }

        return null;
    }

    public void EarlyUpdate(UpdateArgs args)
    {
        if (!Enabled)
            return;

        foreach (var comp in Components)
            comp.EarlyUpdate(args);
    }
    public void Update(UpdateArgs args)
    {
        if (!Enabled)
            return;

        foreach (var comp in Components)
            comp.Update(args);
    }
    public void LateUpdate(UpdateArgs args)
    {
        if (!Enabled)
            return;

        foreach (var comp in Components)
            comp.LateUpdate(args);
    }
    public void Render(RenderArgs args)
    {
        if (!Enabled)
            return;

        foreach (var comp in Components)
            comp.Render(args);
    }
}