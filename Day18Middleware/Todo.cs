using System.ComponentModel.DataAnnotations;

namespace Day18Middleware;

public class Todo
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    public bool Completed { get; set; }

    [Range(1, 5)]
    public int Priority { get; set; }

    public DateTime DueDate { get; set; }
}