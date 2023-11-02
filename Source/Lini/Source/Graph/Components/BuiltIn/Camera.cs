using System.Numerics;
using Lini.Miscellaneous;

namespace Lini.Graph.Components.BuiltIn;

public struct Camera : IComponent
{
    static int IComponent.TypeID { get; set; }
    public Entity Entity { get; set; }

    public float FieldOfView { get; set; }
    public float NearPlane { get; set; }
    public float FarPlane { get; set; }
    public float AspectRatio { get; set; }


    public readonly Matrix4x4 ViewMatrix =>
        Matrix4x4Extensions.CreateLookAt(Entity.AbsoluteTransform);
    public readonly Matrix4x4 ProjectionMatrix =>
        Matrix4x4.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlane, FarPlane);


}