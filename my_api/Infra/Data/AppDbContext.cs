using Microsoft.EntityFrameworkCore;

namespace MY_API.Infra.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }


}