var sonYokiNull = ParseSon(Console.ReadLine());

if(sonYokiNull is not null)
    Console.WriteLine("Son kiritdingiz");

int? ParseSon(string x)
{
    try
    {
        return int.Parse(x);
    }
    catch(Exception)
    {
        return null;
    }
}

// PrintType(5);
// PrintType('c');
// PrintType(new Point() { X = 10, Y = 15 });
// PrintType("hello");

// ReturnMessage(5);
// ReturnMessage('c');
// ReturnMessage(new Point() { X = 10, Y = 15 });
// ReturnMessage("hello");

// string ReturnMessage(object x)
// {
//     var message = x switch
//     {
//         int son => $"Bu son tipi va qiymati {son}",
//         char c => $"Bu char tipi va qiymati {c}",
//         Point p => $"Bu Point tipi va kopaytmasi {p.Kopaytma()}",
//         double _ => $"Bu double tipi.",
//         _ => $"Bu unknown tip va qiymati {x}"
//     };

//     return message;
// }

// void PrintType(object x)
// {
//     if(x is int son)
//         Console.WriteLine($"Bu son tipi va qiymati {son}");
//     else if(x is char c)
//         Console.WriteLine($"Bu char tipi va qiymati {c}");
//     else if(x is Point p)
//         Console.WriteLine($"Bu Point tipi va kopaytmasi {p.Kopaytma()}");
//     else 
//         Console.WriteLine($"Bu unknown tip va qiymati {x}");
// }

// int? xNullable = 123;
// int y = 23;
// object yBoxed = y;
// if (xNullable is int a && yBoxed is int b)
// {
//     Console.WriteLine(a + b);  // output: 30
// }

// DisplayMeasurement(-4);  // Output: Measured value is -4; out of an acceptable range.
// DisplayMeasurement(50);  // Output: Measured value is 50.
// DisplayMeasurement(132);  // Output: Measured value is 132; out of an acceptable range.

// void DisplayMeasurement(int measurement)
// {
//     switch (measurement)
//     {
//         case < 0 or > 100:
//             Console.WriteLine($"Measured value is {measurement}; out of an acceptable range.");
//             break;
        
//         default:
//             Console.WriteLine($"Measured value is {measurement}.");
//             break;
//     }
// }

// var role = Role.Student | Role.Teacher | Role.Admin;


// if((role & Role.Teacher) == Role.Teacher)
// {
//     Console.WriteLine("This is a teacher");
// }


// var oq = Colors.White;
// Console.WriteLine($"Oq rang tarkibi: {oq}");

// var majlisKunlari = WeekDays.Monday | WeekDays.Wednesday | WeekDays.Friday;
// var uydanIshlashKunlari = WeekDays.Tuesday | WeekDays.Friday;

// Console.WriteLine(majlisKunlari);
// Console.WriteLine(uydanIshlashKunlari);
// Console.WriteLine($"Uyda majlis bo'ladigan kunlar: {majlisKunlari & uydanIshlashKunlari}");