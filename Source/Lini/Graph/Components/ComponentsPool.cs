using System.Reflection;
using Lini.Miscellaneous;

namespace Lini.Graph.Components;


internal sealed class ComponentsPool
{

    private List<object> Components { get; init; } = new();
    private List<Action<Delegate>> DoForAll { get; init; } = new();
    private List<Action<int>> ReturnByIndex { get; init; } = new();


    public ComponentsPool()
    {
        foreach (var data in ComponentReflection.ComponentData)
        {
            var compType = typeof(LayeredValuePool<>).MakeGenericType(data.TypeInfo)!;
            var comp = Activator.CreateInstance(compType, 1024)!;
            Components.Add(comp);

            var retMethod = compType.GetMethod(nameof(LayeredValuePool<int>.Return), BindingFlags.Instance | BindingFlags.Public)!;
            ReturnByIndex.Add(retMethod.CreateDelegate<Action<int>>(comp));

            var doForAll = compType.GetMethod(nameof(LayeredValuePool<int>.DoForAllDelegate), BindingFlags.Instance | BindingFlags.NonPublic)!;
            DoForAll.Add(doForAll.CreateDelegate<Action<Delegate>>(comp));
        }
    }

    private LayeredValuePool<T> GetPool<T>() where T : struct, IComponent
        => (Components[T.TypeID] as LayeredValuePool<T>)!;


    internal void Update(UpdateArgs args)
    {
        for (int i = 0; i < Components.Count; i++)
        {
            var data = ComponentReflection.ComponentData[i];
            if (data.EarlyUpdater is not null)
                DoForAll[i](data.EarlyUpdater(args));
        }

        for (int i = 0; i < Components.Count; i++)
        {
            var data = ComponentReflection.ComponentData[i];
            if (data.Updater is not null)
                DoForAll[i](data.Updater(args));
        }

        for (int i = 0; i < Components.Count; i++)
        {
            var data = ComponentReflection.ComponentData[i];
            if (data.LateUpdater is not null)
                DoForAll[i](data.LateUpdater(args));
        }
    }

    public ref T New<T>(out ComponentRef<T> comp) where T : struct, IComponent
    {
        var pool = GetPool<T>();
        var idx = pool.Retrieve();
        comp = new(idx);
        ref T val = ref pool[idx];
        return ref val;
    }

    public ref T New<T>(in T item, out ComponentRef<T> comp) where T : struct, IComponent
    {
        var pool = GetPool<T>();
        var idx = pool.Retrieve(in item);
        comp = new(idx);
        ref T val = ref pool[idx];
        return ref val;
    }

    public void Delete<T>(ComponentRef<T> comp) where T : struct, IComponent
    {
        var pool = GetPool<T>();
        pool.Return(comp.Index);
    }

    public void Delete(PlainComponentRef comp)
    {
        ReturnByIndex[comp.TypeID](comp.Index);
    }

    public ref T Get<T>(ComponentRef<T> comp) where T : struct, IComponent
    {
        var pool = GetPool<T>();
        return ref pool[comp.Index];
    }
}