public struct Taksi
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public string Rusum { get; private set; }

    public Taksi(int x, int y, string rusum)
    {
        X = x;
        Y = y;
        Rusum = rusum;
    }

    public double MengachaMasofa(int x = 0, int y = 0)
    {
        return Math.Sqrt(Math.Pow(x - X, 2) + Math.Pow(y - Y, 2));
    }

    public void Read()
    {
        var splitParametrlar = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        X = int.Parse(splitParametrlar[0]);
        Y = int.Parse(splitParametrlar[1]);
        Rusum = splitParametrlar[2];
    }
}