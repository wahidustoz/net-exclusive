public struct Circle
{
    public Point Center { get; private set; }
    public int Radius { get; private set; }

    public Circle() : this(new Point(), 0) { }

    public Circle(Point center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public bool Contains(Point point)
    {
        return Center.DistanceTo(point) < Radius;
    }
}