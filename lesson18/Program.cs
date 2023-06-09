using System.Diagnostics;

var teaMaker = new TeaMaker();
var stopwatch = new Stopwatch();

Console.WriteLine("Starting to make tea!");
stopwatch.Start();
await teaMaker.MakeTeaAsync();
stopwatch.Stop();
Console.WriteLine($"Tea was made in {stopwatch.Elapsed.TotalMilliseconds}ms");
