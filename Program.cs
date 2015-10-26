var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.MapGet("/users/{id}", (int id) => Results.Ok(new { id }));

app.Run();
- Minor cleanup — iteration 5 (2015)
- Fix lint warnings — iteration 8 (2015)
- Fix edge case — iteration 10 (2015)
- Update dependencies — iteration 14 (2015)
- Update dependencies — iteration 17 (2015)
- Minor cleanup — iteration 18 (2015)
- Improve error handling — iteration 23 (2015)
- Fix edge case — iteration 25 (2015)
- Polish code — iteration 29 (2015)
- Fix edge case — iteration 32 (2015)
