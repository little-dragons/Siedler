using Lini.Graph;
using Lini.Graph.Components;

namespace Client;

public struct CameraMover : IComponent
{
    static int IComponent.TypeID { get; set; }

    public Entity Entity;

    public readonly void Update(UpdateArgs args)
    {
        Entity.Transform.Position.Y += args.WPressed * 0.001f;
    }
}