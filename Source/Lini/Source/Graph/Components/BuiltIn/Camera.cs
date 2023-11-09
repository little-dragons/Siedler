using System.Numerics;

namespace Lini.Graph.Components.BuiltIn;

public struct Camera : IComponent
{
    static int IComponent.TypeID { get; set; }

    public required Entity Entity;

    public required float FieldOfView;
    public required float NearPlane;
    public required float FarPlane;
    public required float AspectRatio;


    public readonly Matrix4x4 ViewMatrix
    {
        get
        {
            Matrix4x4.Invert(Entity.AbsoluteTransform, out var res);
            return res;
        }
    }

    public readonly Matrix4x4 ProjectionMatrix
        => Matrix4x4.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlane, FarPlane);
}