// Minimal ASP.NET Core API host.
// Intentionally no endpoints/business logic yet (training starter).

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();
