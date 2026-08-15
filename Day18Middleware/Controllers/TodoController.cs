using Microsoft.AspNetCore.Mvc;
using Day18Middleware;
namespace Day18Middleware.Controllers;
/// <summary>
/// Provides API endpoints for managing Todo items.
/// </summary>

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    /// <summary>
    /// Gets all Todos items. 
    /// </summary>
    /// <param name="todo">The Todo item to create.</param>
    /// <returns>The newly created Todo item.</returns>
    [HttpGet]
    public IActionResult GetTodos()
    {
        var todos = new List<Todo>
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
        todo.Id = 3;
        return CreatedAtAction(
            nameof(GetTodos),
            new { id = todo.Id },
            todo);
    }
        }