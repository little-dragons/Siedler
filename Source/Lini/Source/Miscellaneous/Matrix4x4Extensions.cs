using System.Numerics;

namespace Lini.Miscellaneous;

public static class Matrix4x4Extensions
{
    public static Matrix4x4 CreateLookAt(in Matrix4x4 transform)
    {
        Matrix4x4 camTransform = transform;
        var eye = Vector3.Transform(Vector3.Zero, camTransform);
        var up = Vector3.TransformNormal(Vector3.UnitY, camTransform);
        var target = Vector3.Transform(-Vector3.UnitZ, camTransform);
        return Matrix4x4.CreateLookAt(eye, target, up);    
    }
}