using System.Numerics;

namespace Lini.Graph;

public struct Entity : IRenderable
{
    private List<Component> Components { get; init; } = new();
    private List<IRenderable> Renderables { get; init; } = new();

    private List<Entity> Children { get; init; } = new();
    private Entity? Parent { get; set; }

    public Transform Transform = new();

    /// <summary>
    /// This is a very slow method, because it needs to traverse the entire graph
    /// and thus should be used with care.
    /// </summary>
    public Matrix4x4 AbsoluteTransform {
        get {
            if (Parent is null)
                return Transform.Matrix;
            else
                return Parent.AbsoluteTransform * Transform.Matrix;
        }
    }

    public bool Enabled { get; set; } = true;

    public void AddChild(Entity entity)
    {
        entity.Parent = this;
        Children.Add(entity);
    }

    public void RemoveChild(Entity entity)
    {
        Children.Remove(entity);
    }

    public void SetComponent<T>(T component) where T : Component
    {
        component.RegisterFor(this);

        bool hasReplaced = false;
        for (int i = 0; i < Components.Count && !hasReplaced; i++)
        {
            if (Components[i] is T)
            {
                Components[i].Deregister();
                Components[i] = component;
                hasReplaced = true;
            }
        }

        if (!hasReplaced)
            Components.Add(component);


        if (component is IRenderable renderable)
        {
            hasReplaced = false;
            for (int i = 0; i < Renderables.Count && !hasReplaced; i++)
            {
                if (Renderables[i] is T)
                {
                    Renderables[i] = renderable;
                    hasReplaced = true;
                }
            }

            if (!hasReplaced)
                Renderables.Add(renderable);
        }
    }

    public void RemoveComponent<T>() where T : Component
    {
        for (int i = 0; i < Components.Count; i++)
        {
            if (Components[i] is T)
            {
                Components[i].Deregister();

                if (Components[i] is IRenderable r)
                    Renderables.Remove(r);

                Components.RemoveAt(i);
                return;
            }
        }
    }

    public T? GetComponent<T>() where T : Component
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

        foreach (var child in Children)
            child.EarlyUpdate(args);
        foreach (var comp in Components)
            comp.EarlyUpdate(args);
    }
    public void Update(UpdateArgs args)
    {
        if (!Enabled)
            return;

        foreach (var child in Children)
            child.Update(args);
        foreach (var comp in Components)
            comp.Update(args);
    }
    public void LateUpdate(UpdateArgs args)
    {
        if (!Enabled)
            return;

        foreach (var child in Children)
            child.LateUpdate(args);
        foreach (var comp in Components)
            comp.LateUpdate(args);
    }
    
    void IRenderable.Render(RenderArgs args)
    {
        if (!Enabled)
            return;

        Matrix4x4 entityToWorld = args.Transforms.Peek() * Transform.Matrix;
        args.Transforms.Push(entityToWorld);

        foreach (var child in Children)
            ((IRenderable)child).Render(args);

        foreach (var comp in Renderables)
            comp.Render(args);

        args.Transforms.Pop();
    }
}