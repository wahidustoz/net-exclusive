// var p = new Point(5, 10);
// p.SetProperties(-5, 100);
// Console.WriteLine(p);
public struct Point 
{
    private int masofa = 0;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
        masofa = -3;
    }

    public int X { get; set; }
    public int Y { get; set; }

    public readonly void SetProperties(int x, int y)
    {
        SetPropertiesOk(x, y, 15);
    }

    private void SetPropertiesOk(int x, int y, int masofa)
    {
        X = x;
        Y = y;
        this.masofa = masofa;
    }

    public override string ToString()
        => $"{X} {Y} {masofa}";
}