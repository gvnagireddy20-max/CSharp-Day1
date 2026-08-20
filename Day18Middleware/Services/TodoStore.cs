using Day18Middleware;

namespace Day18Middleware.Services;

public class TodoStore : ITodoStore
{
    private readonly object _lock = new();

    private readonly List<Todo> _todos = new()
    {
        new Todo
        {
            Id = 1,
            Title = "Learn Middleware",
            Completed = false,
            Priority = 3,
            DueDate = DateTime.Now.AddDays(1)
        },

        new Todo
        {
            Id = 2,
            Title = "Learn Swagger",
            Completed = false,
            Priority = 3,
            DueDate = DateTime.Now.AddDays(2)
        }
    };

    public IEnumerable<Todo> GetAll()
    {
        lock (_lock)
        {
            return _todos.ToList();
        }
    }

    public Todo? GetById(int id)
    {
        lock (_lock)
        {
            return _todos.FirstOrDefault(todo => todo.Id == id);
        }
    }

    public Todo Add(Todo todo)
    {
        lock (_lock)
        {
            _todos.Add(todo);
            return todo;
        }
    }

    public bool Update(int id, Todo todo)
    {
        lock (_lock)
        {
            var existingTodo = _todos.FirstOrDefault(todo => todo.Id == id);

            if (existingTodo == null)
            {
                return false;
            }

            existingTodo.Title = todo.Title;
            existingTodo.Completed = todo.Completed;
            existingTodo.Priority = todo.Priority;
            existingTodo.DueDate = todo.DueDate;

            return true;
        }
    }

    public bool Delete(int id)
    {
        lock (_lock)
        {
            var todo = _todos.FirstOrDefault(todo => todo.Id == id);

            if (todo == null)
            {
                return false;
            }

            _todos.Remove(todo);

            return true;
        }
    }
}