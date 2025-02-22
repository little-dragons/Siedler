using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using Lini.Graph.Components;

namespace Lini.Graph;

public sealed class Entity
{
    private ComponentList Components { get; init; } = new();

    private List<Entity> Children { get; init; } = [];
    public Entity? Parent { get; private set; } = null;

    private Layer Layer { get; init; }
    public bool EnableRendering { get; set; } = true;

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


    internal Entity(Layer layer)
    {
        Layer = layer;
    }

    public Entity MakeChild()
    {
        Entity e = new(Layer)
        {
            Parent = this
        };
        Children.Add(e);
        return e;
    }

    public bool DeleteChild(Entity entity)
    {
        if (Children.Remove(entity))
        {
            entity.Dispose();

            return true;
        }

        return false;
    }



    private List<ValueTuple<PlainComponentRef, Action<Render3DArgs>>> Renderables3D { get; init; } = [];
    private bool HasRenderables3D => Renderables3D.Count > 0 || Children.Any(x => x.HasRenderables3D);
    private List<ValueTuple<PlainComponentRef, Action<RenderUIArgs>>> RenderablesUI { get; init; } = [];
    private bool HasRenderablesUI => RenderablesUI.Count > 0 || Children.Any(x => x.HasRenderablesUI);


    public ref T TryAdd<T>(out bool success, out ComponentRef<T> compRef) where T : struct, IComponent
    {
        ref T comp = ref Layer.Components.New(out compRef);
        if (!Components.TryAdd(compRef.Plain))
        {
            Layer.Components.Delete(compRef);
            success = false;
            return ref Unsafe.NullRef<T>();
        }


        if (comp is IRenderable3D)
        {
            ComponentRef<T> copy = compRef;
            void renderFun(Render3DArgs x) => ((IRenderable3D)Layer.Components.Get(copy)).Render(x);
            Renderables3D.Add((compRef.Plain, renderFun));
        }
        if (comp is IRenderableUI)
        {
            ComponentRef<T> copy = compRef;
            void renderFun(RenderUIArgs x) => ((IRenderableUI)Layer.Components.Get(copy)).Render(x);
            RenderablesUI.Add((compRef.Plain, renderFun));
        }

        success = true;
        return ref comp;
    }

    public ref T Add<T>(out ComponentRef<T> comp) where T : struct, IComponent
        => ref TryAdd(out bool _, out comp);

    public ref T Add<T>() where T : struct, IComponent
        => ref TryAdd<T>(out bool _, out var _);

    public bool TryGet<T>([NotNullWhen(true)] out ComponentRef<T>? compRef) where T : struct, IComponent
        => Components.TryGet(out compRef);

    public void Remove<T>(ComponentRef<T> comp) where T : struct, IComponent
    {
        if (comp is IRenderable3D)
            Renderables3D.RemoveAll(x => x.Item1 == comp.Plain);
        if (comp is IRenderableUI)
            RenderablesUI.RemoveAll(x => x.Item1 == comp.Plain);

        Components.Free(comp.Plain);
        Layer.Components.Delete(comp);
    }

    internal void Render3D(Render3DArgs args)
    {
        if (!EnableRendering || !HasRenderables3D)
            return;

        Matrix4x4 entityToWorld = args.Transforms.Peek() * Transform.Matrix;
        args.Transforms.Push(entityToWorld);

        foreach (var child in Children)
            child.Render3D(args);

        foreach (var comp in Renderables3D)
            comp.Item2(args);

        args.Transforms.Pop();
    }

    internal void RenderUI(RenderUIArgs args)
    {
        if (!EnableRendering || !HasRenderablesUI)
            return;

        foreach (var child in Children)
            child.RenderUI(args);

        foreach (var comp in RenderablesUI)
            comp.Item2(args);
    }



    private void Dispose()
    {
        Parent = null;

        foreach (var child in Children)
            child.Dispose();
        
        Children.Clear();

        foreach (var component in Components)
            Layer.Components.Delete(component);
    }
}