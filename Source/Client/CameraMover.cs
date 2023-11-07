using System.Numerics;
using Lini.Graph;
using Lini.Graph.Components;
using Lini.Windowing.Input;

namespace Client;

public struct CameraMover : IComponent
{
    static int IComponent.TypeID { get; set; }

    public Entity Entity;
    public float Speed;

    public CameraMover(Entity entity, float speed)
    {
        Entity = entity;
        Speed = speed;
    }

    public readonly void Update(UpdateArgs args)
    {
        Vector3 direction = Vector3.Zero;
        if (args.Keyboard.IsDown(Key.W))
            direction -= Vector3.UnitZ;
        if (args.Keyboard.IsDown(Key.S))
            direction += Vector3.UnitZ;
        if (args.Keyboard.IsDown(Key.D))
            direction += Vector3.UnitX;
        if (args.Keyboard.IsDown(Key.A))
            direction -= Vector3.UnitX;
        if (args.Keyboard.IsDown(Key.LeftShift))
            direction += Vector3.UnitY;
        if (args.Keyboard.IsDown(Key.LeftControl))
            direction -= Vector3.UnitY;

        if (direction != Vector3.Zero) {
            var transformedDirection = Vector3.Transform(direction / direction.Length(), Entity.Transform.Rotation);
            Entity.Transform.Position += transformedDirection * Speed * args.DeltaTime;
        }
    }
}