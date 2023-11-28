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
}