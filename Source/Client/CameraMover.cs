using Lini.Graph;
using Lini.Graph.Components;
namespace Client;


public struct CameraMover : IComponent
{
    public Entity Entity { get; set; }
    static int IComponent.TypeID { get; set; }

    public void Update(UpdateArgs args)
    {
        Entity.Transform.Position.Y += args.WPressed * 0.001f;
        // Console.WriteLine("Updates");
    }
}