using System.Numerics;
using Lini;
using Lini.Graph;
using Lini.Graph.Components;
using Lini.Windowing.Input;

namespace Client;

public struct CameraMover : IComponent
{
    static int IComponent.TypeID { get; set; }

    public required Entity Entity;
    public required float Speed;


    public readonly void Update(UpdateArgs args)
    {
        Vector3 direction = Vector3.Zero;
        if (args.Input.IsDown(Key.W))
            direction -= Vector3.UnitZ;
        if (args.Input.IsDown(Key.S))
            direction += Vector3.UnitZ;
        if (args.Input.IsDown(Key.D))
            direction += Vector3.UnitX;
        if (args.Input.IsDown(Key.A))
            direction -= Vector3.UnitX;
        if (args.Input.IsDown(Key.LeftShift))
            direction += Vector3.UnitY;
        if (args.Input.IsDown(Key.LeftControl))
            direction -= Vector3.UnitY;

        if (direction != Vector3.Zero)
        {
            var transformedDirection = Vector3.Transform(direction / direction.Length(), Entity.Transform.Rotation);
            Entity.Transform.Position += transformedDirection * Speed * args.DeltaTime;
        }

        if (args.Input.IsPressed(Key.Space))
            if (Sam.Window.IsFullscreen)
            {
                Sam.Window.MakeWindow((200, 200), (800, 800), 60);
            }
            else
                Sam.Window.MakeFullscreen();

        if (args.Input.IsPressed(Key.RightControl))
        {
            Sam.Window.LockCursor();
        }

        if (Sam.Window.IsFullscreen)
        {
            Console.WriteLine(args.Input.MousePixelDelta);
            Console.WriteLine(args.Input.RawMouseDelta);
            Console.WriteLine("----");
        }
    }
}