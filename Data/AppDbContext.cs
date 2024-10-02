using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models; // Adjust to fit your project's actual namespace

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define DbSets for each model representing a table in the database
        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }
    }

    // Example models (these should be separated into their own files under the Models folder)
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Purchase
    {
        public int Id { get; set; }
        public int AppId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
