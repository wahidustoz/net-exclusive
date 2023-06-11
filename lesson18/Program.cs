
Console.WriteLine($"{string.IsNullOrEmpty(null)} {string.IsNullOrWhiteSpace(null)}");
Console.WriteLine($"{string.IsNullOrEmpty("")} {string.IsNullOrWhiteSpace("")}");
Console.WriteLine($"{string.IsNullOrEmpty(" ")} {string.IsNullOrWhiteSpace(" ")}");
Console.WriteLine($"{string.IsNullOrEmpty("\n")} {string.IsNullOrWhiteSpace("\n")}");
Console.WriteLine($"{string.IsNullOrEmpty("  \n \t")} {string.IsNullOrWhiteSpace("  \n \t")}");











// using System.Diagnostics;

// var teaMaker = new TeaMaker();
// var stopwatch = new Stopwatch();

// Console.WriteLine("Starting to make tea!");
// stopwatch.Start();
// await teaMaker.MakeTeaAsync();
// stopwatch.Stop();
// Console.WriteLine($"Tea was made in {stopwatch.Elapsed.TotalMilliseconds}ms");


// using System.Diagnostics;
// using System.Net.Http.Json;

// // var cardclient = new HttpClient(){ BaseAddress = new Uri("https://api.placeholderjson.dev") };

// // async Task PrintCardAsync(int id)
// // {
// //     var card = await GetCardAsync(id);
// //     Console.WriteLine(card);
// // }

// // Task<Card> GetCardAsync(int id)
// //     => client.GetFromJsonAsync<Card>($"/credit-card/{id}");


// var client = new HttpClient(){ BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };

// var stopwatch = new Stopwatch();
// stopwatch.Start();

// var tasks = new List<Task>();

// for(int i = 1; i <= 100; i++)
// {
//     // tasks.Add(PrintPostAsync(i));

//     // var post = await GetPostAsync(i);
//     // await InsertPostAsync(post);
//     //          |
//     //          |
//     tasks.Add(GetPostAndInsertAsync(i));
// }

// await Task.WhenAny(tasks);

// stopwatch.Stop();
// Console.WriteLine($"FINISHED in {stopwatch.Elapsed.TotalMilliseconds}ms");



// async Task PrintPostAsync(int id)
// {
//     var card = await GetPostAsync(id);
//     Console.WriteLine(card);
// }

// async Task GetPostAndInsertAsync(int id)
// {
//     var post = await GetPostAsync(id);
//     await InsertPostAsync(post);
// }

// Task<Post> GetPostAsync(int id)
//     => client.GetFromJsonAsync<Post>($"/posts/{id}");

// Task InsertPostAsync(Post post)
// {
//     Console.WriteLine(post);
//     return Task.Delay(100);
// }


// // asinxron method Task<T> qaytarsa
// // va agar shu method ichida await qilinsa, bu method T qaytarishi shart
// // ichida await yo'q bo'lsa, method nomiga async qo'yish shart emas.
// // va method Task<T> qaytarishi shart