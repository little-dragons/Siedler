using System.Numerics;

namespace Lini.Graph.Components;

public class Camera : Component
{
    public float FieldOfView { get; set; }
    public float NearPlane { get; set; }
    public float FarPlane { get; set; }
    public float AspectRatio { get; set; }

    public Matrix4x4 ProjectionMatrix =>
        Matrix4x4.CreatePerspectiveFieldOfView(FieldOfView, AspectRatio, NearPlane, FarPlane);

    public Matrix4x4 ViewMatrix
    {
        get
        {
            Matrix4x4 camTransform = Entity!.AbsoluteTransform;
            var eye = Vector3.Transform(Vector3.Zero, camTransform);
            var up = Vector3.TransformNormal(Vector3.UnitY, camTransform);
            var target = Vector3.Transform(Vector3.UnitZ, camTransform);
            return Matrix4x4.CreateLookAt(eye, target, up);
        }
    }
}