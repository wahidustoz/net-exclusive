public struct Planet
{
    public Location Center { get; private set; }
    public int Radius { get; private set; }

    public Planet(Location center, int radius)
    {
        Center = center;
        Radius = radius;
    }

    public bool Ichidami(Location location)
    {
        return Center.Masofa(location) < Radius;
    }
}