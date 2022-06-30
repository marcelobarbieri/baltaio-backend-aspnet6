var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // adiciona suporte aos Controllers

var app = builder.Build();

app.MapControllers(); // mapeia os Controllers

app.Run();
