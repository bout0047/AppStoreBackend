using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models;  // Add this to reference the User model

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Define DbSet properties for each model in your application
        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Games" },
                new Category { Id = 2, Name = "Productivity" },
                new Category { Id = 3, Name = "Education" }
            );

            // Seeding Apps
            modelBuilder.Entity<App>().HasData(
                new App { Id = 1, Name = "Super Fun Game", Description = "An amazing game that is fun to play!", CategoryId = 1 },
                new App { Id = 2, Name = "Work Organizer", Description = "Boost your productivity with this organizer app.", CategoryId = 2 },
                new App { Id = 3, Name = "Learn Spanish", Description = "An educational app for learning Spanish.", CategoryId = 3 }
            );

            // Seeding Users - Ensure all required fields, such as Name, are provided
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "john_doe", Name = "John Doe", Email = "john@example.com", Password = "hashed_password_here" },
                new User { Id = 2, Username = "jane_smith", Name = "Jane Smith", Email = "jane@example.com", Password = "hashed_password_here" }
            );

            // Seeding Purchases
            modelBuilder.Entity<Purchase>().HasData(
                new Purchase { Id = 1, UserId = 1, AppId = 1, PurchaseDate = new DateTime(2023, 1, 1) },
                new Purchase { Id = 2, UserId = 2, AppId = 2, PurchaseDate = new DateTime(2023, 2, 15) }
            );
        }

    }
}
