using System.Linq.Expressions;
using System.Reflection;
using Lini.Miscellaneous;

namespace Lini.Graph.Components;

/// <summary>
/// This class gathers information about all types implementing <see cref="IComponent"/> by reflection.
/// </summary>
internal static class ComponentReflection
{
    /// <summary>
    /// This class stores extracted data by reflection. <see cref="TypeInfo"/> stores whose component's data
    /// this instance stores and then also provides methods to access the update methods.
    /// </summary>
    public class Entry
    {
        /// <summary>
        /// The type of the component derivign from <see cref="IComponent"/>.
        /// </summary>
        public readonly TypeInfo TypeInfo;

        /// <summary>
        /// This is a function returning another function. Given an instance of <see cref="UpdateArgs"/>,
        /// it provides a method for an object of type <see cref="TypeInfo"/> to call its 
        /// <see cref="IComponent.Update(UpdateArgs)"/> method. Because the type is dynamic, it cannot be
        /// expressed in the type system more clearly.
        /// </summary>
        public readonly Func<UpdateArgs, Delegate>? Updater;

        /// <summary>
        /// See the documentation of <see cref="Updater"/>.
        /// </summary>
        public readonly Func<UpdateArgs, Delegate>? EarlyUpdater;

        /// <summary>
        /// See the documentation of <see cref="Updater"/>.
        /// </summary>
        public readonly Func<UpdateArgs, Delegate>? LateUpdater;

        public Entry(TypeInfo typeInfo, Func<UpdateArgs, Delegate>? updater, Func<UpdateArgs, Delegate>? earlyUpdater, Func<UpdateArgs, Delegate>? lateUpdater)
        {
            TypeInfo = typeInfo;
            Updater = updater;
            EarlyUpdater = earlyUpdater;
            LateUpdater = lateUpdater;
        }
    }

    private static readonly List<Entry> Entries = new();
    public static IReadOnlyList<Entry> ReadOnlyEntries => Entries.AsReadOnly();

    public static bool IsInitialized => Entries.Any();

    public static void Initialize(IEnumerable<Assembly> assemblies)
    {

        foreach (var assembly in assemblies)
            foreach (TypeInfo info in assembly.DefinedTypes)
            {
                if (!info.ImplementedInterfaces.Contains(typeof(IComponent)))
                    continue;

                if (!info.IsValueType)
                    Logger.Warn($"The type {info.FullName} implements {nameof(IComponent)} but is not a value type. Unexpected behavior may occur.");

                Func<UpdateArgs, Delegate>? updater = null;
                Func<UpdateArgs, Delegate>? earlyUpdater = null;
                Func<UpdateArgs, Delegate>? lateUpdater = null;
                int id = Entries.Count;

                var property = info.GetProperty(typeof(IComponent).FullName + "." + nameof(IComponent.TypeID), BindingFlags.Static | BindingFlags.NonPublic)!;
                property.SetValue(null, id);

                {
                    var early = info.GetMethod(nameof(IComponent.EarlyUpdate))!;
                    var normal = info.GetMethod(nameof(IComponent.Update))!;
                    var late = info.GetMethod(nameof(IComponent.LateUpdate))!;

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



                Entries.Add(new(info, updater, earlyUpdater, lateUpdater));
            }

    }

    public static void Terminate()
    {
        Entries.Clear();
    }
}