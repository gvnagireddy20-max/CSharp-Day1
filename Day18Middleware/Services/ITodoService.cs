using Day18Middleware;

namespace Day18Middleware.Services;

public interface ITodoService
{
    IEnumerable<Todo> GetTodos();

    Todo? GetTodo(int id);

    Todo CreateTodo(Todo todo);

    bool UpdateTodo(int id, Todo todo);

    bool DeleteTodo(int id);
}