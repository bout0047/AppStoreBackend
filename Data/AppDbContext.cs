using Microsoft.EntityFrameworkCore;
using AppStoreBackend.Models;

namespace AppStoreBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<App> Apps { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<App>()
                .Property(a => a.Price)
                .HasColumnType("decimal(18,2)"); // Ensure correct decimal precision

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.User)
                .WithMany(u => u.Purchases)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<Purchase>()
                .HasOne(p => p.App)
                .WithMany(a => a.Purchases)
                .HasForeignKey(p => p.AppId);
        }
    }
}
