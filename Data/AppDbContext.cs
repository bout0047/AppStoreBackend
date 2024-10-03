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
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adding seed data with a value for 'IconPath'.
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Games", Description = "All fun games", IconPath = "path/to/games/icon.png" },
                new Category { Id = 2, Name = "Productivity", Description = "Boost your productivity", IconPath = "path/to/productivity/icon.png" },
                new Category { Id = 3, Name = "Education", Description = "Learn something new", IconPath = "path/to/education/icon.png" }
            );

            modelBuilder.Entity<App>().HasData(
                new App { Id = 1, Name = "Super Fun Game", Description = "An amazing game that is fun to play!", CategoryId = 1 },
                new App { Id = 2, Name = "Work Organizer", Description = "Boost your productivity with this organizer app.", CategoryId = 2 },
                new App { Id = 3, Name = "Learn Spanish", Description = "An educational app for learning Spanish.", CategoryId = 3 }
            );
        }

    }
}
