using Day18Middleware;

namespace Day18Middleware.Services;

public class TodoService : ITodoService
{
    private readonly ITodoStore _store;

    public TodoService(ITodoStore store)
    {
        _store = store;
    }

    public IEnumerable<Todo> GetTodos()
    {
        return _store.GetAll();
    }

    public Todo? GetTodo(Guid id)
    {
        return _store.GetById(id);
    }

    public Todo CreateTodo(Todo todo)
    {
        return _store.Add(todo);
    }

    public bool UpdateTodo(Guid id, Todo todo)
    {
        return _store.Update(id, todo);
    }

    public bool DeleteTodo(Guid id)
    {
        return _store.Delete(id);
    }
}