using MY_API.Domain.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/login", (AdminDTO adminDTO) =>
{
    if (adminDTO.Email == "adm@teste.com" && adminDTO.PassowrdHash == "")
    {
        return Results.Ok("Passou no teste de adm");
    }
    return Results.Unauthorized();
});

app.Run();
