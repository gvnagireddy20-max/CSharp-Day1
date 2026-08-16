using Day18Middleware;

namespace Day18Middleware.Services;

public class TodoService : ITodoService
{
    private readonly List<Todo> _todos = new()
    {
        new Todo
        {
            Id = 1,
            Title = "Learn Middleware",
            Completed = false
        },
        new Todo
        {
            Id = 2,
            Title = "Learn Swagger",
            Completed = false
        }
    };

    public List<Todo> GetTodos()
    {
        return _todos;
    }

    public Todo CreateTodo(Todo todo)
    {
        todo.Id = _todos.Count + 1;

        _todos.Add(todo);

        return todo;
    }
}