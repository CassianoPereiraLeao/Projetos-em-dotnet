using System.ComponentModel.DataAnnotations;
using MY_API.typesformation;

namespace MY_API.Domain.Entities;

public class Admin
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    [StringLength(100)]
    public Email Email { get; set; } = default!;
    [Required]
    [MinLength(8)]
    [MaxLength(12)]
    public Password Password { get; set; } = default!;

    [Required]
    public string Profile { get; set; } = default!;
}