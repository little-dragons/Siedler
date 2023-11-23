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
            Matrix4x4 absolute = Entity.AbsoluteTransform;
            // Matrix4x4.Invert(absolute, out absolute);
            Vector3 eye = Vector3.Transform(Vector3.Zero, absolute);
            Vector3 target = Vector3.Transform(-Vector3.UnitZ, absolute);
            Vector3 up = Vector3.TransformNormal(Vector3.UnitY, absolute);
            return Matrix4x4.CreateLookAt(eye, target, up);
        }
    }

    public readonly Matrix4x4 ProjectionMatrix
        => Matrix4x4.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlane, FarPlane);
}