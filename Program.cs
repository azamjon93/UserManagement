using UserManagement.Middleware;
using UserManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<UserService>();
builder.Services.AddLogging();

var app = builder.Build();

// Configure middleware
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<AuthenticationMiddleware>();

// Configure the app to use Swagger
app.UseSwagger(options => { });
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();