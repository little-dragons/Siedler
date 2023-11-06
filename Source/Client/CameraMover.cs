using Lini.Graph;
using Lini.Graph.Components;
using Lini.Windowing.Input;

namespace Client;

public struct CameraMover : IComponent
{
    static int IComponent.TypeID { get; set; }

    public Entity Entity;

    public readonly void Update(UpdateArgs args)
    {
        if (args.Keyboard.IsDown(Key.Space) || args.Mouse.IsDown(MouseButton.Left))
            Entity.Transform.Position.Y += 0.001f;
    }
}