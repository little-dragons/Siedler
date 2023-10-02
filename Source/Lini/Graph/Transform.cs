using System.Numerics;

namespace Lini.Graph;

public struct Transform
{
    public Vector3 Position;
    public Quaternion Rotation;
    public Vector3 Scale;

    public Transform()
    {
        Scale = Vector3.One;
        Position = Vector3.Zero;
        Rotation = Quaternion.Identity;
    }


    public Matrix4x4 Matrix =>
        Matrix4x4.CreateTranslation(Position) *
        Matrix4x4.CreateFromQuaternion(Rotation) *
        Matrix4x4.CreateScale(Scale);
}