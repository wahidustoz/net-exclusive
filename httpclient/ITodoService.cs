public interface ITodoService
{
    Task<Todo> GetTodoAsync(int id, CancellationToken cancellationToken = default);
}
