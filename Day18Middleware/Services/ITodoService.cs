using Day18Middleware;

namespace Day18Middleware.Services;

public interface ITodoService
{
    IEnumerable<Todo> GetTodos();

    Todo? GetTodo(Guid id);

    Todo CreateTodo(Todo todo);

    bool UpdateTodo(Guid id, Todo todo);

    bool DeleteTodo(Guid id);
}