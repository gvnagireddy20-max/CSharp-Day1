using System.Collections.Concurrent;
using Day18Middleware;

namespace Day18Middleware.Services;

public class TodoStore : ITodoStore
{
    private readonly ConcurrentDictionary<Guid, Todo> _todos = new();

    public TodoStore()
    {
        var todo1 = new Todo
        {
            Id = Guid.NewGuid(),
            Title = "Learn Middleware",
            Completed = false
        };

        var todo2 = new Todo
        {
            Id = Guid.NewGuid(),
            Title = "Learn Swagger",
            Completed = false
        };

        _todos.TryAdd(todo1.Id, todo1);
        _todos.TryAdd(todo2.Id, todo2);
    }

    public IEnumerable<Todo> GetAll()
    {
        return _todos.Values;
    }

    public Todo? GetById(Guid id)
    {
        _todos.TryGetValue(id, out var todo);

        return todo;
    }

    public Todo Add(Todo todo)
    {
        todo.Id = Guid.NewGuid();

        _todos.TryAdd(todo.Id, todo);

        return todo;
    }

    public bool Update(Guid id, Todo todo)
    {
        if (!_todos.TryGetValue(id, out var existingTodo))
        {
            return false;
        }

        todo.Id = id;

        return _todos.TryUpdate(id, todo, existingTodo);
    }

    public bool Delete(Guid id)
    {
        return _todos.TryRemove(id, out _);
    }
}