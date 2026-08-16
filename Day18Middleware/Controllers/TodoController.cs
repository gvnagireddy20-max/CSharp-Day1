using Microsoft.AspNetCore.Mvc;
using Day18Middleware;
using Day18Middleware.Services;

namespace Day18Middleware.Controllers;

/// <summary>
/// Provides API endpoints for managing Todo items.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoService _todoService;
    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }
    /// <summary>
    /// Gets all Todo items.
    /// </summary>
    /// <returns>A list of Todo items.</returns>
    /// <response code="200">Returns the list of Todo items.</response>
    [HttpGet]
    public IActionResult GetTodos()
    {
        var todos = _todoService.GetTodos();
       
        return Ok(todos);
    }

    /// <summary>
    /// Creates a new Todo item.
    /// </summary>
    /// <param name="todo">The Todo item to create.</param>
    /// <returns>The newly created Todo item.</returns>
    /// <response code="201">The Todo item was successfully created.</response>
    [HttpPost]
    public IActionResult CreateTodo(Todo todo)
    {
        var createdTodo = _todoService.CreateTodo(todo);

        return CreatedAtAction(
            nameof(GetTodos),
            new { id = createdTodo.Id },
            createdTodo);
    }
}