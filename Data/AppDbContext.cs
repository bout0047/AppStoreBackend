using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models; // Make sure this only appears once

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ApplicationData> Apps { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }  // Correct reference to the Purchase class from Models
    }
}
