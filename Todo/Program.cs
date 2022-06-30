using Todo.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // adiciona suporte aos Controllers
builder.Services.AddDbContext<AppDbContext>(); // adiciona suporte ao DbContext

var app = builder.Build();

app.MapControllers(); // mapeia os Controllers

app.Run();
