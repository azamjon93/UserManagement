namespace UserManagement.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context); // Call the next middleware
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing the request");
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("An error occurred while processing the request");
            }
        }
    }
}