using System.Diagnostics;

namespace Day18Middleware;
/// <summary>
/// Middleware that logs incoming requests and their execution time.
/// </summary>
public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    /// <summary>
    /// Creates a new instance of the logging middleware.
    /// </summary>
    /// <param name="next">The next middleware component in the request pipeline.</param>

    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    /// <summary>
    ///  Processes the HTTP request and logs its execution time.
    /// </summary>
    /// <param name="context">The current HTTP request context.</param>
    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();
        Console.WriteLine(
    $"Request started: {context.Request.Method} {context.Request.Path}");
    await _next(context);
    stopwatch.Stop();
    Console.WriteLine(
    $"Request completed in {stopwatch.ElapsedMilliseconds} ms");
    }
}