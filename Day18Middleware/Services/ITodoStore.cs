using Day18Middleware;

namespace Day18Middleware.Services;

public interface ITodoStore
{
    IEnumerable<Todo> GetAll();

    Todo? GetById(Guid id);

    Todo Add(Todo todo);

    bool Update(Guid id, Todo todo);

    bool Delete(Guid id);


}