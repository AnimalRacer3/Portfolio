using Microsoft.EntityFrameworkCore;
using PackageTracker.Models;

namespace PackageTracker.Context
{
    public class PackageDbContext : DbContext
    {
        public PackageDbContext(DbContextOptions<PackageDbContext> options) : base(options)
        {

        }
        public DbSet<PackageModel> Packages { get; set; }
    }
}