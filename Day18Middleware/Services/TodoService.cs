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

    public Todo? GetTodo(int id)
    {
        return _store.GetById(id);
    }

    public Todo CreateTodo(Todo todo)
    {
        todo.Id = _store.GetAll().Any()
            ? _store.GetAll().Max(t => t.Id) + 1
            : 1;

        return _store.Add(todo);
    }

    public bool UpdateTodo(int id, Todo todo)
    {
        return _store.Update(id, todo);
    }

    public bool DeleteTodo(int id)
    {
        return _store.Delete(id);
    }
}