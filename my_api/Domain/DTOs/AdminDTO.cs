using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using MY_API.typesformation;

namespace MY_API.Domain.DTOs;

public class AdminDTO
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Email Email { get; set; } = default!;
    public Password PassowrdHash { get; set; } = default!;
}