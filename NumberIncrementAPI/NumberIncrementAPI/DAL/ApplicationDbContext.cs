using Microsoft.EntityFrameworkCore;

using NumberIncrementAPI.Models;

namespace NumberIncrementAPI.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Number> Numbers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
