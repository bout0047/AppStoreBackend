using AppStoreBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; } // Assuming you have a `User` model
    }
}
