

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello ");
app.MapPost("/login", (Domain.DTOs.LoginDTO loginDTO) => 
{
    if (loginDTO.Username == "admin" && loginDTO.Password == "password")
    {
        return Results.Ok("Login successful");
    }
        return Results.Unauthorized();
});
    app.Run();