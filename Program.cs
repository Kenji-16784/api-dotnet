var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint GET
app.MapGet("/api/saludo", () =>
{
    return new { mensaje = "Hola desde .NET API 🚀" };
});

// Endpoint POST
app.MapPost("/api/guardar", (dynamic data) =>
{
    return new { mensaje = "Datos recibidos", data };
});

app.Run();
