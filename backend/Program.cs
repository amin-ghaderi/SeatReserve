var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPost("/reservation", async (HttpRequest request) =>
{
    var form = await request.ReadFormAsync();

    Console.WriteLine(form["username"]);
    Console.WriteLine(form["timeslot"]);
    Console.WriteLine(form["seatnumber"]);
    Console.WriteLine(form["receipt"]);

    return Results.Ok(
    $"Reservation for {form["username"]} received!"
);
});

app.Run();