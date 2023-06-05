var sonlar = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(x => x > 2);


// var sonlar = new int[] { 1, 2, 3, 4, 5 };
// var juftlarniKvadratlari = sonlar
//     .Where(x => x % 2 == 0)
//     .Select(x => x * x);

// var faqatJuftlar = sonlar.Select((int x) => x % 2 == 0);
// var kvadratlar = sonlar.Select(x => x.ToString());

// var sozlar = new string[] { "Hello", "world", "salom", "qalaysiz", "nima gap" };

// var loSiBorlar = sozlar.Select(x => x.Contains("lo"));


// int RandomInt()
// {
//     return new Random().Next();
// }

// int Kvadrat(int a)
// {
//     return a * a;
// }

// string Reverse(string txt)
// {
//     var arr = txt.ToArray();
//     Array.Reverse(arr);

//     return new string(arr);
// }

// int Parse(string txt)
// {
//     return int.Parse(txt);
// }

// Func<string?> read = Console.ReadLine;
// Func<int> random = RandomInt;

// Func<int, int> lyuboy = Kvadrat;
// Func<string, string> blabla = Reverse;
// Func<string, int> intParser = Parse;

// var text = read();
// var randomSon = random();

// Console.WriteLine($"Kiritildi: {text}");
// Console.WriteLine($"Random: {randomSon}");
// Console.WriteLine($"Kvadrat: {lyuboy(10)}");
// Console.WriteLine($"reverse: {blabla("salom")}");
// Console.WriteLine($"reverse: {intParser("123")}");



// void WriteToFile(string msg)
// {
//     File.WriteAllText("message.txt", msg);
// }

// MyDelegate print = Console.WriteLine;
// print += WriteToFile;

// print("Hello world");

// public delegate void MyDelegate(string msg);

// Del reverse = (x) => {

//     var arr = x.ToArray();
//     Array.Reverse(arr);

//     return new string(arr);
// };

// Console.WriteLine(reverse("Hello World"));


// public delegate string Del(string txt);


// // void CalledWhenVideoConverted()
// // {
// //     Console.WriteLine("Video has been converted");
// // }

// // var converter = new VideoConverter();

// // converter.Convert(new byte[] { }, CalledWhenVideoConverted);

// bool Juftmi(int son)
// {
//     Console.WriteLine("Juftmi chaqirilidi");
//     return son % 2 == 0;
// }

// bool Toqmi(int son)
// {
//     Console.WriteLine("Toqmi chaqirilidi");
//     return son % 2 == 1;
// }


// MyDelegate falonchi = Juftmi + Toqmi;
// falonchi += Toqmi;
// falonchi += Juftmi;

// falonchi -= Juftmi;
// falonchi -= Juftmi;
// falonchi -= Toqmi;

// // Console.WriteLine(falonchi(10));
// Console.WriteLine(falonchi?.Invoke(10));

// public delegate bool MyDelegate(int son);