using Day18Middleware;
namespace Day18Middleware.Services;
public interface ITodoService
{
    List<Todo> GetTodos();
    Todo CreateTodo(Todo todo);
}