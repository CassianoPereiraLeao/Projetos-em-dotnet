using Microsoft.EntityFrameworkCore;
using MY_API.Domain.Entities;
using MY_API.typesformation;

namespace MY_API.Infra.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Admin> Admins { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            var adminId = Guid.NewGuid();

            entity.OwnsOne(a => a.Email, emailOwned =>
            {
                emailOwned.Property<string>("_email").HasColumnName("Email");

                emailOwned.HasData(new { AdminId = adminId, _email = "admin@teste.com" });
            });

            entity.OwnsOne(a => a.Password, passwordOwned =>
            {
                passwordOwned.Property<string>("_password").HasColumnName("Password");

                passwordOwned.HasData(new { AdminId = adminId, _password = "admin" });
            });

            entity.HasData(new { Id = adminId, Profile = "admin" });
        });
    }
}