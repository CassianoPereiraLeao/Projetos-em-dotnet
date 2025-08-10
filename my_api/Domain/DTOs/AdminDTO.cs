using Microsoft.AspNetCore.Identity;
using MY_API.typesformation;

namespace MY_API.Domain.DTOs;

public class AdminDTO
{
    public Guid id;
    public string Email = default!;
    public string PassowrdHash = default!;
}