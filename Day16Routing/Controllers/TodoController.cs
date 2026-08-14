// using Microsoft.AspNetCore.Mvc;

// [ApiController]
// [Route("api/todos")]
// public class TodoController : ControllerBase
// {
//     private readonly List<Todo> todos = new()
//     {
//         new Todo { Id = 1, Title = "Learn c#"},
//         new Todo { Id = 2, Title = "Learn ASP.NET Core"},
//         new Todo { Id = 3, Title = "Practice REST API"}
//         };
//         [HttpGet]
//         public IActionResult GetTodo()
//     {
//         return Ok(todos);
//     }

//     [HttpGet("{id}")]

//     public IActionResult GetTodo(int id)
//     {
//         var todo = todos.FirstOrDefault(t => t.Id == id);

//         if(todo == null)
//         {
//             return NotFound();

//         }
//         return Ok(todo);
//     }

//     [HttpPost]

//     public IActionResult CreateTodo()
//     {
//         return Ok("Post endpoint reached");
//     }

//     [HttpPut("{id}")]
//     public IActionResult UpdateTodo(int id)
//     {
//         return Ok($"Put endpoint reached for Todo {id}");
//     }

//     [HttpDelete("{id}")]

// public IActionResult DeleteTodo(int id)
//     {
//         return Ok($"DELETE endpoint reached for Todo {id}");
//     }

// }

using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/todos")]

public class TodoController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetTodo([FromRoute] int id)
    {
        return Ok($"Todo id is {id}");
    }

    [HttpGet]
    public IActionResult GetTodo([FromQuery] bool? completed)
    {
        return Ok($"Completed filter: {completed}");
    }
    [HttpPost]
    public IActionResult CreateTodo([FromBody] Todo todo)
    {
        return Ok (todo);
    }


}