using System.Numerics;
using Lini.Miscellaneous;

namespace Lini.Graph.Components.BuiltIn;

public struct Camera : IComponent
{
    static int IComponent.TypeID { get; set; }

    public Entity Entity;

    public float FieldOfView;
    public float NearPlane;
    public float FarPlane;
    public float AspectRatio;


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