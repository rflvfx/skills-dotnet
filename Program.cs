var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.MapGet("/users/{id}", (int id) => Results.Ok(new { id }));

app.Run();
