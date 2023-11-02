using System.Linq.Expressions;
using System.Reflection;
using Lini.Miscellaneous;

namespace Lini.Graph.Components;

internal static partial class ComponentReflection
{
    public class Data
    {
        public readonly TypeInfo TypeInfo;
        public readonly Func<UpdateArgs, Delegate>? Updater;
        public readonly Func<UpdateArgs, Delegate>? EarlyUpdater;
        public readonly Func<UpdateArgs, Delegate>? LateUpdater;

        public Data(TypeInfo typeInfo, Func<UpdateArgs, Delegate>? updater, Func<UpdateArgs, Delegate>? earlyUpdater, Func<UpdateArgs, Delegate>? lateUpdater)
        {
            TypeInfo = typeInfo;
            Updater = updater;
            EarlyUpdater = earlyUpdater;
            LateUpdater = lateUpdater;
        }
    }

    private static readonly List<Data> WriteComponentData = new();
    public static readonly IReadOnlyList<Data> ComponentData = WriteComponentData.AsReadOnly();

    public static bool IsInitialized => WriteComponentData.Any();

    public static void Initialize(IEnumerable<Assembly> assemblies)
    {

        foreach (var assembly in assemblies)
            foreach (TypeInfo info in assembly.DefinedTypes)
            {
                if (!info.ImplementedInterfaces.Contains(typeof(IComponent)))
                    continue;

                Func<UpdateArgs, Delegate>? updater = null;
                Func<UpdateArgs, Delegate>? earlyUpdater = null;
                Func<UpdateArgs, Delegate>? lateUpdater = null;
                int id = WriteComponentData.Count;

                var property = info.GetProperty(typeof(IComponent).FullName + "." + nameof(IComponent.TypeID), BindingFlags.Static | BindingFlags.NonPublic);
                property!.SetValue(null, id);

                {
                    var early = info.GetMethod(nameof(IComponent.EarlyUpdate), BindingFlags.Instance | BindingFlags.Public)!;
                    var normal = info.GetMethod(nameof(IComponent.Update), BindingFlags.Instance | BindingFlags.Public)!;
                    var late = info.GetMethod(nameof(IComponent.LateUpdate), BindingFlags.Instance | BindingFlags.Public)!;

                    var actionType = typeof(RefAction<>).MakeGenericType(info.AsType());

                    if (normal is not null)
                    {
                        var target = Expression.Parameter(info.MakeByRefType());
                        var args = Expression.Parameter(typeof(UpdateArgs));
                        var method = Expression.Lambda(actionType, Expression.Call(target, normal, args), target);
                        var wrapper = Expression.Lambda<Func<UpdateArgs, Delegate>>(method, args);
                        updater = wrapper.Compile();
                    }

                    if (early is not null)
                    {
                        var target = Expression.Parameter(info.MakeByRefType());
                        var args = Expression.Parameter(typeof(UpdateArgs));
                        var method = Expression.Lambda(actionType, Expression.Call(target, early, args), target);
                        var wrapper = Expression.Lambda<Func<UpdateArgs, Delegate>>(method, args);
                        var caller = wrapper.Compile();
                    }
                    if (late is not null)
                    {
                        var target = Expression.Parameter(info.MakeByRefType());
                        var args = Expression.Parameter(typeof(UpdateArgs));
                        var method = Expression.Lambda(actionType, Expression.Call(target, late, args), target);
                        var wrapper = Expression.Lambda<Func<UpdateArgs, Delegate>>(method, args);
                        lateUpdater = wrapper.Compile();
                    }
                }



                WriteComponentData.Add(new(info, updater, earlyUpdater, lateUpdater));
            }

    }

    public static void Terminate()
    {
        WriteComponentData.Clear();
    }
}