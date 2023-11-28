using System.Numerics;

namespace Lini.Numerics;

public struct Vector2i
{
    public int X;
    public int Y;

    public Vector2i()
    {
        X = 0;
        Y = 0;
    }
    public Vector2i(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static implicit operator Vector2(Vector2i vec)
        => new(vec.X, vec.Y);
    public static explicit operator Vector2i(Vector2 vec)
        => new((int)vec.X, (int)vec.Y);

    public readonly void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}