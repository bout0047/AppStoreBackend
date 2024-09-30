using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Categories table
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Productivity", IconPath = "icons/productivity.png" },
                new Category { CategoryID = 2, CategoryName = "Games", IconPath = "icons/games.png" }
            );

            // Seed data for Apps table
            modelBuilder.Entity<App>().HasData(
                new App { AppID = 1, Name = "ToDo App", Description = "Task management app", Price = 0.0m, IsPopular = true, CategoryID = 1 },
                new App { AppID = 2, Name = "Space Invaders", Description = "Classic arcade game", Price = 4.99m, IsPopular = false, CategoryID = 2 }
            );

            // Seed data for Users table
            modelBuilder.Entity<User>().HasData(
                new User { UserID = 1, Username = "testuser", Email = "testuser@example.com", Password = "password123" }
            );
        }
    }
}
