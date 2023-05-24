var jagged = new int[2][] 
{
    new int[] { 1, 2, 3, 4, 5 },
    new int[] { 6, 7, 8, 9 }
};

for(int i = 0; i < jagged.Length; i++)
{
    Console.WriteLine($"Elementlari soni: {jagged[i].Length}");
    for(int j = 0; j < jagged[i].Length; j++)
        Console.Write($"{jagged[i][j]} ");

    Console.WriteLine();
}

// foreach(var array in jagged)
// {
//     Console.WriteLine($"Elementlari soni: {array.Length}");
//     foreach(var son in array)
//         Console.Write($"{son} ");
    
//     Console.WriteLine();
// }


// int[] sonlar = new int[3];
// int[] sonlar = new int[] { 1, 2, 3 };
// var sonlar = new int[] { 1, 2, 3 };
// int[] sonlar = { 1, 2, 3, 4 };      // array initialization syntax


// int[,,] array3Da = new int[2, 2, 3]
// { 
//     { 
//         { 1, 2, 3 }, 
//         { 4, 5, 6 } 
//     },                     
//     { 
//         { 7, 8, 9 }, 
//         { 10, 11, 12 }
//     } 
// };

// Console.WriteLine($"{array3Da.Length} {array3Da.Rank}");
// for(int i = 0; i < array3Da.Rank; i++)
// {
//     Console.WriteLine(array3Da.GetLength(i));
// }

// TekstToHex();

// RobotgaErgash();

static void RobotgaErgash()
{
    var harkatlarSoni = int.Parse(Console.ReadLine());

    var qadamlar = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse);

    var location = new Location(0, 0);
    var direction = Direction.Up;

    foreach (var qadam in qadamlar)
    {
        switch (direction)
        {
            case Direction.Up:
                location.Y += qadam; break;
            case Direction.Right:
                location.X += qadam; break;
            case Direction.Down:
                location.Y -= qadam; break;
            case Direction.Left:
                location.X -= qadam; break;
        }

        direction = (Direction)(((int)direction + 1) % 4);
    }

    Console.WriteLine(location);
}

static void TekstToHex()
{
    var tekst = Console.ReadLine().TrimEnd();

    foreach (var belgi in tekst)
    {
        Console.Write($"{(int)belgi:X2} ");
    }
}