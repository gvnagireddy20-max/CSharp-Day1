using Day18Middleware;

namespace Day18Middleware.Services;

public interface ITodoStore
{
    IEnumerable<Todo> GetAll();

    Todo? GetById(int id);

    Todo Add(Todo todo);

    bool Update(int id, Todo todo);

    bool Delete(int id);
}