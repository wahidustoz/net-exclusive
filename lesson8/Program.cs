
















// decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
//     => (groupSize, visitDate.DayOfWeek) switch
//     {
//         (<= 0, _) => throw new ArgumentException("Group size must be positive."),
//         (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
//         (>= 5 and < 10, DayOfWeek.Monday) => 20.0m,
//         (>= 10, DayOfWeek.Monday) => 30.0m,
//         (>= 5 and < 10, _) => 12.0m,
//         (>= 10, _) => 15.0m,
//         _ => 0.0m,
    // };

// int x;
// TryParseInt(Console.ReadLine(), out x);

// void TryParseInt(string text, out int son)
// {
//     try
//     {
//         son = int.Parse(text);
//     }
//     catch(Exception)
//     {
//         son = 0;
//     }
// }

// bool IsInBirinchiChorak(Kesma kesma) =>
//     kesma is { Start.X: > 0 } and { Start.Y: > 0 } and { End.X: > 0 } and { End.Y: > 0 }
//     // kesma is { Start: { X: > 0 } an}d { Y: > 0 }  and { End: { X: > 0 } and { Y: > 0 } };

// record Nuqta(int X, int Y);
// record Kesma(Nuqta Start, Nuqta End);


// bool IsLower(char c) => 
//     c is (>= 'a' and <= 'z');

// bool IsLetter(char c) => 
//     c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z');

// var son = int.Parse(Console.ReadLine());
// var habar = son switch
// {
//     0 => "nol",
//     < 0 => "manfiy",
//     > 0 => "musbat"
// };

// Console.WriteLine(habar);



// var son = int.Parse(Console.ReadLine());
// var isJuft = son % 2 == 0;

// if(isJuft is true && son is not 0)
//     Console.WriteLine("Juft son");
// else
//     Console.WriteLine("Toq son");
