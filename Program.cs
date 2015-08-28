var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.MapGet("/users/{id}", (int id) => Results.Ok(new { id }));

app.Run();
- Minor cleanup — iteration 5 (2015)
- Fix lint warnings — iteration 8 (2015)
