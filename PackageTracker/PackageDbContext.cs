using Microsoft.EntityFrameworkCore;

public class PackageDbContext : DbContext
{
    public DbSet<Package> Packages {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("connection string");
    }
}