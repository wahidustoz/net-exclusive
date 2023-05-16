var testlar = int.Parse(Console.ReadLine());

while(testlar-- > 0)
{
    var kesishlarSoni = 0;
    
    var koordinatalar = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    var shaxzodaJoyi = new Location(koordinatalar[0], koordinatalar[1]);
    var malikaJoyi = new Location(koordinatalar[2], koordinatalar[3]);

    var planetalarSoni = int.Parse(Console.ReadLine());
    while(planetalarSoni-- > 0)
    {
        var planetaSonlari = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var planeta = new Planet(
            center: new Location(planetaSonlari[0], planetaSonlari[1]), 
            radius: planetaSonlari[2]);
        
        var shaxzodaIchidami = planeta.Ichidami(shaxzodaJoyi);
        var malikaIchidami = planeta.Ichidami(malikaJoyi);

        if(shaxzodaIchidami ^ malikaIchidami)
            kesishlarSoni++;
    }

    Console.WriteLine(kesishlarSoni);
}