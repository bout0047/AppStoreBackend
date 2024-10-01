using AppStoreBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ApplicationData> Apps { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }

    public class ApplicationData
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Added default value
        public string Description { get; set; } = string.Empty; // Added default value
        public Category Category { get; set; } = new Category(); // Added default value to avoid null warnings
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty; // Ensure these properties are assigned
        public string Password { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }

    public class Purchase
    {
        public int Id { get; set; }
        public User User { get; set; } = new User(); // Added default value
        public int UserId { get; set; }
        public ApplicationData App { get; set; } = new ApplicationData(); // Added default value
        public int AppId { get; set; }
        public DbSet<Purchase> Purchases { get; set; } // This refers to the Purchase class in Models

        public decimal Price { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
