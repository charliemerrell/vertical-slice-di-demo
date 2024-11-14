using VerticalDi.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<GetHeroHandler>();
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();