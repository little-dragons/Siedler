using Lini.Numerics;

namespace Lini.UI;

public struct Rectangle
{
    public required Point Point1 { get; set; }
    public required Point Point2 { get; set; }

    public readonly Point Point3 => new()
    {
        Offset = new(Point2.Offset.X, Point1.Offset.Y),
        Percent = new(Point2.Percent.X, Point1.Percent.Y)
    };

    public readonly Point Point4 => new()
    {
        Offset = new(Point1.Offset.X, Point2.Offset.Y),
        Percent = new(Point1.Percent.X, Point2.Percent.Y)
    };

    /// <summary>
    /// Returns points 1 through 4 in an ordered array.
    /// </summary>
    public readonly Point[] ToArray()
        => [Point1, Point2, Point3, Point4];

    private readonly void ToPixelArray(Vector2i windowSize, Span<Vector2i> pixels)
    {
        pixels[0] = Point1.ToPixel(windowSize);
        pixels[1] = Point2.ToPixel(windowSize);
        pixels[2] = Point3.ToPixel(windowSize);
        pixels[3] = Point4.ToPixel(windowSize);
    }

    private readonly void GetBoundingPoints(Vector2i windowSize, out Vector2i min, out Vector2i max)
    {
        int minX;
        int minY;
        int maxX;
        int maxY;

        Vector2i point1Pix = Point1.ToPixel(windowSize);
        Vector2i point2Pix = Point2.ToPixel(windowSize);

        if (point1Pix.X < point2Pix.X)
        {
            minX = point1Pix.X;
            maxX = point2Pix.X;
        }
        else
        {
            minX = point2Pix.X;
            maxX = point1Pix.X;
        }
        if (point1Pix.Y < point2Pix.Y)
        {
            minY = point1Pix.Y;
            maxY = point2Pix.Y;
        }
        else
        {
            minY = point2Pix.Y;
            maxY = point1Pix.Y;
        }
        min = new(minX, minY);
        max = new(maxX, maxY);
    }

    public readonly bool Contains(Vector2i pixel, Vector2i windowSize)
    {
        GetBoundingPoints(windowSize, out Vector2i min, out Vector2i max);
        var x = pixel.X;
        var y = pixel.Y;
        var x1 = min.X;
        var y1 = max.Y;
        var x2 = max.X;
        var y2 = max.Y;
        var x3 = max.X;
        var y3 = min.Y;
        var x4 = min.X;
        var y4 = min.Y;
        var a = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
        var b = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
        var c = (x3 - x) * (y4 - y3) - (x4 - x3) * (y3 - y);
        var d = (x4 - x) * (y1 - y4) - (x1 - x4) * (y4 - y);
        return (a > 0 && b > 0 && c > 0 && d > 0) || (a < 0 && b < 0 && c < 0 && d < 0);
    }
}