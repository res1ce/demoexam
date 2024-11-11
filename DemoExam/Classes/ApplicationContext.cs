using DemoExam.Models;
using Microsoft.EntityFrameworkCore;

namespace YourNamespace
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Partner> Partners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sales> Sales { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }
}
