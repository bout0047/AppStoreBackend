using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models; // Import the correct namespace for the models

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        // Seed data for the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Games" },
                new Category { Id = 2, Name = "Utilities" }
            );

            // Seed Apps
            modelBuilder.Entity<App>().HasData(
                new App { Id = 1, Name = "Chess", Description = "A classic chess game", CategoryId = 1 },
                new App { Id = 2, Name = "Calculator", Description = "Basic calculator app", CategoryId = 2 }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "User1", Email = "user1@example.com" },
                new User { Id = 2, Username = "User2", Email = "user2@example.com" }
            );
        }
    }
}
