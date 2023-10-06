using Microsoft.OpenApi.Models;
using RedResQ_API.Lib;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Todo API",
        Description = "Keep Track of your tasks",
        Version = "v1"
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TODO API V1");
});

app.MapGet("/", () => "Hello 1!");
app.MapGet("/test", () => "Hello 2!");
app.MapPost("/echo", (Product p) =>
{
    Product temp = new Product(int.MaxValue - p.Id, p.Name.Reverse().ToString());
    Console.WriteLine(p.ToString());
    
    return new { p.Id, p.Name, temp};
});

app.Run();