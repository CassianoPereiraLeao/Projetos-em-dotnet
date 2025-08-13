using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MY_API.Domain.DTOs;
using MY_API.Infra.Data;
using MY_API.typesformation;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

app.MapGet("/login", ([FromBody] AdminDTO adminDTO) =>
{
    Email email = new("adm@teste.com");
    Password password = new("qwert");

    if (adminDTO.Email == email && adminDTO.PassowrdHash == password)
    {
        return Results.Ok("Passou no teste de adm");
    }
    return Results.Unauthorized();
});

app.Run();
