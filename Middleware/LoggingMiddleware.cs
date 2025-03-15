using System.Diagnostics;

namespace UserManagement.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            // Log request details
            _logger.LogInformation("Handling request: {Method} {Path}", context.Request.Method, context.Request.Path);

            await _next(context); // Call the next middleware

            stopwatch.Stop();

            // Log response details
            _logger.LogInformation("Finished handling request. Status code: {StatusCode} in {ElapsedMilliseconds} ms", 
                context.Response.StatusCode, stopwatch.ElapsedMilliseconds);
        }
    }
}