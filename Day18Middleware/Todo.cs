namespace Day18Middleware;

/// <summary>
/// Represents a task in the Todo Application.
/// </summary>

public class Todo
{
    /// <summary>
    /// The unique identifier of the task.
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// The title of the task
    /// </summary>
    public string Title { get; set; } = string.Empty;
    /// <summary>
    /// Identicates whether the task has been completed.
    /// </summary>
    public bool Completed { get; set; }

}