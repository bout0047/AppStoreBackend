using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; } // Ensure Purchase is correctly included

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // You can add model relationships and constraints here if needed
        }
    }
}
