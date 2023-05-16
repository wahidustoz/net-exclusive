public struct Location
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Location(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Masofa(Location location)
    {
        return Math.Sqrt(Math.Pow(location.X - X, 2) + Math.Pow(location.Y - Y, 2));
    }
}