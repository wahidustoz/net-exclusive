public struct Point
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Point() : this(0, 0) { }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Point point)
    {
        var a = point.X - X;
        var b = point.Y - Y;
        var cKvadrat = Math.Pow(a, 2) + Math.Pow(b, 2);

        return Math.Sqrt(cKvadrat);
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }
}