using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor to pass DbContext options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSets for each model to manage database tables
        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        // Model configurations if required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Example configurations: relationships, constraints, etc.
            modelBuilder.Entity<App>()
                .HasOne(a => a.Category) // An app has one category
                .WithMany()              // A category can have many apps
                .HasForeignKey(a => a.CategoryId); // Foreign key relationship

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.App)
                .WithMany()
                .HasForeignKey(p => p.AppId);
        }
    }
}
