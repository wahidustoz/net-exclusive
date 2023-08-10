public class TodoService : ITodoService
{
    private readonly HttpClient client;

    public TodoService(HttpClient client) => this.client = client;

    public Task<Todo> GetTodoAsync(int id, CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<Todo>($"/todos/{id}");
}