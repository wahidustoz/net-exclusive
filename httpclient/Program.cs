var builder = WebApplication.CreateBuilder(args);

var jsonClientName = "JsonPlaceholder";
// named http client
builder.Services.AddHttpClient(
    name: jsonClientName, 
    configureClient: options => options.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"));

// typed http client
builder.Services.AddHttpClient<ITodoService, TodoService>(
    options => options.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"));

var app = builder.Build();

app.MapGet("/named", async (IHttpClientFactory clientFactory) =>
{
    var client = clientFactory.CreateClient(jsonClientName);
    // HttpResponseMessage response = await client.GetAsync("/todo2/3");

    // return new 
    // {
    //     StatusCode = response.StatusCode,
    //     Headers = response.Headers,
    //     Reason = response.ReasonPhrase,
    //     Data = await response.Content.ReadAsStringAsync()
    // };

    // return await client.GetStringAsync("/todos/3");

    var todo = await client.GetFromJsonAsync<Todo>("/todos/3");
    return todo;
});

app.MapGet("/typed", async (ITodoService todoService, CancellationToken cancellationToken) 
    => await todoService.GetTodoAsync(1, cancellationToken));

app.Run();