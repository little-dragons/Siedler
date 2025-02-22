using Lini.Graph.Components;
using Lini.Graph.Components.BuiltIn;
using Lini.Windowing.Input;

namespace Lini.Graph;

public class Scene
{
    private List<Layer> ModifiableLayers { get; init; }
    public IReadOnlyList<Layer> Layers => ModifiableLayers.AsReadOnly();
    public Layer GetOrCreateLayer(int index)
    {
        var res = ModifiableLayers.Find(x => x.Index == index);
        if (res is not null)
            return res;


        Layer l = new()
        {
            Index = index,
            Scene = this,
        };

        ModifiableLayers.Add(l);
        ModifiableLayers.Sort((a, b) => a.Index.CompareTo(b.Index));
        return l;
    }


    public Scene()
    {
        ModifiableLayers = [];
    }


    internal void UpdateAll(UpdateArgs args)
    {
        for (int i = Layers.Count - 1; i >= 0; i--)
            Layers[i].Components.Update(args);
    }

    internal void Render3D(Render3DArgs args)
    {
        for (int i = 0; i < Layers.Count; i++)
            Layers[i].Render3D(args);
    }

    internal void RenderUI(RenderUIArgs args)
    {
        for (int i = 0; i < Layers.Count; i++)
            Layers[i].RenderUI(args);
    }
}