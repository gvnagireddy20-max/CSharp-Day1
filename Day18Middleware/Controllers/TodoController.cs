using Microsoft.AspNetCore.Mvc;
using Day18Middleware;
using Day18Middleware.Services;

namespace Day18Middleware.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;

    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public IActionResult GetTodos()
    {
        var todos = _todoService.GetTodos();

        return Ok(todos);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetTodo(int id)
    {
        var todo = _todoService.GetTodo(id);

        if (todo == null)
        {
            return NotFound();
        }

        return Ok(todo);
    }

    [HttpPost]
    public IActionResult CreateTodo(Todo todo)
    {
        var createdTodo = _todoService.CreateTodo(todo);

        return CreatedAtAction(
            nameof(GetTodo),
            new { id = createdTodo.Id },
            createdTodo);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateTodo(int id, Todo todo)
    {
        var updated = _todoService.UpdateTodo(id, todo);

        if (!updated)
        {
            return NotFound();
        }

        return Ok(_todoService.GetTodo(id));
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteTodo(int id)
    {
        var deleted = _todoService.DeleteTodo(id);

        if (!deleted)
        {
            return NotFound();
        }

        return Ok();
    }
}