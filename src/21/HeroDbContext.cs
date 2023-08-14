using Microsoft.EntityFrameworkCore;

namespace program;


public class HeroDbContext : DbContext
{
    public DbSet<Hero>? Heros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=Magic1412;Database=test;Trusted_Connection=True;TrustServerCertificate=true;";
        optionsBuilder.UseSqlServer(connectionString);
    }
}