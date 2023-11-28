using System.Numerics;
using Lini;
using Lini.Graph;
using Lini.Graph.Components;
using Lini.Windowing;
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

        float xRot = 0;
        if (args.Input.IsDown(Key.E))
            xRot -= 0.004f;
        if (args.Input.IsDown(Key.Q))
            xRot += 0.004f;

        if (xRot != 0)
            Entity.Transform.Rotation *= Quaternion.CreateFromYawPitchRoll(xRot, 0.0f, 0.0f);

        if (args.Input.MouseDelta != Vector2.Zero && args.CurrentWindowInfo.CursorLocked)
        {
            Vector2 mouseDelta  = args.Input.MouseDelta * 0.000001f;
            Entity.Transform.Rotation *= Quaternion.CreateFromYawPitchRoll(0.0f, mouseDelta.Y, 0.0f);
            Entity.Transform.Rotation *= Quaternion.CreateFromYawPitchRoll(-mouseDelta.X, 0.0f, 0.0f);
            Console.WriteLine(args.Input.MouseDelta);
        }

        if (args.Input.IsPressed(Key.Space))
            if (args.TargetWindowInfo.IsFullscreen)
                args.TargetWindowInfo = args.TargetWindowInfo with { FullscreenOptions = new(new WindowedInfo(new(200, 200))), Resolution = new(800, 800) };
            else
                args.TargetWindowInfo = args.TargetWindowInfo with { FullscreenOptions = new(new FullscreenInfo()), Resolution = new(2560, 1440) };

        if (args.Input.IsPressed(Key.RightControl))
            args.TargetWindowInfo = args.TargetWindowInfo with { CursorLocked = !args.TargetWindowInfo.CursorLocked };

    }
}