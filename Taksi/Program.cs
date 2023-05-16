var taksilarSoni = int.Parse(Console.ReadLine());

var engYaqinTaksi = new Taksi();
engYaqinTaksi.Read();
taksilarSoni--;

while(taksilarSoni-- > 0)
{
    var yangiTaski = new Taksi();
    yangiTaski.Read();

    if(yangiTaski.MengachaMasofa() < engYaqinTaksi.MengachaMasofa())
        engYaqinTaksi = yangiTaski;
}

Console.WriteLine($"{engYaqinTaksi.Rusum} {engYaqinTaksi.MengachaMasofa():F2}");