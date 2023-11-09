using System.Numerics;
using System.Runtime.CompilerServices;
using Lini.Graph.Components;

namespace Lini.Graph;

public sealed class Entity
{
    private ComponentList Components { get; init; } = new();
    private List<ValueTuple<PlainComponentRef, Action<RenderArgs>>> Renderables { get; init; } = new();

    public List<Entity> Children { get; init; } = new();
    public Entity Parent { get; private set; }

    private Scene Scene { get; init; }

    internal Entity(Scene scene)
    {
        Scene = scene;
        Parent = null!;
    }

    public Transform Transform = new();

    /// <summary>
    /// This is a very slow method, because it needs to traverse the entire graph
    /// and thus should be used with care.
    /// </summary>
    public Matrix4x4 AbsoluteTransform
    {
        get
        {
            if (Parent is null)
                return Transform.Matrix;
            else
                return Parent.AbsoluteTransform * Transform.Matrix;
        }
    }

    public bool Enabled { get; set; } = true;

    public Entity MakeChild()
    {
        Entity e = Scene.NewEntity();
        e.Parent = this;
        Children.Add(e);
        return e;
    }

    public void Delete()
    {
        if (Parent is not null && Parent.Children.Remove(this))
        {
            Parent = null!;
            foreach (var child in Children)
                child.Delete();

            foreach (var component in Components.AsSpan())
                Scene.Components.Delete(component);
        }
    }


    public ref T TryAdd<T>(out bool success, out ComponentRef<T> compRef) where T : struct, IComponent
    {
        ref T comp = ref Scene.Components.New(out compRef);
        if (!Components.TryAdd(compRef.Plain))
        {
            Scene.Components.Delete(compRef);
            success = false;
            return ref Unsafe.NullRef<T>();
        }


        if (comp is IRenderable)
        {
            var refCopy = compRef;
            Renderables.Add((compRef.Plain, x => ((IRenderable)Scene.Components.Get(refCopy)).Render(x)));
        }

        success = true;
        return ref comp;
    }

    public ref T Add<T>(out ComponentRef<T> comp) where T : struct, IComponent
        => ref TryAdd(out bool _, out comp);

    public ref T Add<T>() where T : struct, IComponent
        => ref TryAdd<T>(out bool _, out var _);

    public bool TryGet<T>(out ComponentRef<T> compRef) where T : struct, IComponent
        => Components.TryGet(out compRef);

    public void Remove<T>(ComponentRef<T> comp) where T : struct, IComponent
    {
        if (comp is IRenderable)
        {
            int i = Renderables.FindIndex(x => x.Item1.Full == comp.Plain.Full);
            if (i >= 0)
                Renderables.RemoveAt(i);
        }

        Components.Free(comp.Plain);
    }

    internal void Render(RenderArgs args)
    {
        if (!Enabled)
            return;

        Matrix4x4 entityToWorld = args.Transforms.Peek() * Transform.Matrix;
        args.Transforms.Push(entityToWorld);

        foreach (var child in Children)
            child.Render(args);

        foreach (var comp in Renderables)
            comp.Item2(args);

        args.Transforms.Pop();
    }
}