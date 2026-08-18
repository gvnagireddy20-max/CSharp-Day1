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
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult GetTodos()
    {
        var todos = _todoService.GetTodos();

        return Ok(todos);
    }

    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetTodo(Guid id)
    {
        var todo = _todoService.GetTodo(id);

        if (todo == null)
        {
            return NotFound();
        }

        return Ok(todo);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public IActionResult CreateTodo(Todo todo)
    {
        var createdTodo = _todoService.CreateTodo(todo);

        return CreatedAtAction(
            nameof(GetTodo),
            new { id = createdTodo.Id },
            createdTodo);
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult UpdateTodo(Guid id, Todo todo)
    {
        var updated = _todoService.UpdateTodo(id, todo);

        if (!updated)
        {
            return NotFound();
        }

        var updatedTodo = _todoService.GetTodo(id);

        return Ok(updatedTodo);
    }

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteTodo(Guid id)
    {
        var deleted = _todoService.DeleteTodo(id);

        if (!deleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}