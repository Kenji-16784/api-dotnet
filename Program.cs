var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// GET /api/saludo
app.MapGet("/api/saludo", () =>
{
    return new { mensaje = "Hola desde .NET API 🚀" };
});

// POST /api/guardar
app.MapPost("/api/guardar", (dynamic data) =>
{
    return new { mensaje = "Datos recibidos", data };
});

app.Run();
