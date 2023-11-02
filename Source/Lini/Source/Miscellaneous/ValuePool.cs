using System.Runtime.InteropServices;

namespace Lini.Miscellaneous;

public class ValuePool<T> where T : struct
{
    private readonly List<T> Items;
    private readonly Stack<int> Holes;

    public int Count => Items.Count - Holes.Count;


    public ValuePool(int initialCapacity)
    {
        Items = new(initialCapacity);
        Holes = new(initialCapacity / 100);
    }

    public delegate void Changer(ref T item);

    public void Change(int index, Changer changer)
    {
        T item = Items[index];
        changer(ref item);
        Items[index] = item;
    }

    public void Do(Action<T> action, int index)
    {
        action(Items[index]);
    }

    public void DoForAll(Action<T> action)
    {
        int[] sortedHoles = new int[Holes.Count];
        Holes.CopyTo(sortedHoles, 0);
        Array.Sort(sortedHoles);

        int lastHole = -1;
        foreach (int hole in sortedHoles)
        {
            for (int i = lastHole + 1; i < hole; i++)
                action(Items[i]);

            lastHole = hole;
        }

        for (int i = lastHole + 1; i < Items.Count; i++)
            action(Items[i]);
    }

    public int Retrieve()
    {
        if (Holes.TryPop(out int index))
        {
            Items[index] = default;
            return index;
        }

        Items.Add(default);
        return Items.Count - 1;
    }

    public void Return(int index)
    {
        Holes.Push(index);
    }
}