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
                new Category { Id = 3, Name = "Education", Description = "Learn something new", IconPath = "path/to/education/icon.png" },
                new Category { Id = 4, Name = "Entertainment", Description = "Entertainment and leisure apps", IconPath = "path/to/entertainment/icon.png" },
                new Category { Id = 5, Name = "Health", Description = "Health and fitness apps", IconPath = "path/to/health/icon.png" }
            );

            modelBuilder.Entity<App>().HasData(
                new App { Id = 1, Name = "Super Fun Game", Description = "An amazing game that is fun to play!", CategoryId = 1 },
                new App { Id = 2, Name = "Work Organizer", Description = "Boost your productivity with this organizer app.", CategoryId = 2 },
                new App { Id = 3, Name = "Learn Spanish", Description = "An educational app for learning Spanish.", CategoryId = 3 },
                new App { Id = 4, Name = "FitLife", Description = "Track your fitness and health goals.", CategoryId = 5 },
                new App { Id = 5, Name = "Movie Night", Description = "An app for finding and streaming movies.", CategoryId = 4 },
                new App { Id = 6, Name = "Word Quest", Description = "A challenging word game to test your vocabulary.", CategoryId = 1 },
                new App { Id = 7, Name = "Daily Planner", Description = "Organize your day with ease.", CategoryId = 2 },
                new App { Id = 8, Name = "Math Genius", Description = "Learn and master mathematics with engaging lessons.", CategoryId = 3 },
                new App { Id = 9, Name = "Yoga for All", Description = "Practice yoga and stay healthy.", CategoryId = 5 },
                new App { Id = 10, Name = "Music Streamer", Description = "Stream your favorite songs anytime.", CategoryId = 4 },
                new App { Id = 11, Name = "Battle Heroes", Description = "Become a hero in this action-packed game.", CategoryId = 1 },
                new App { Id = 12, Name = "Team Collaborator", Description = "A productivity app to manage team projects.", CategoryId = 2 },
                new App { Id = 13, Name = "Science Facts", Description = "Learn amazing facts about science.", CategoryId = 3 },
                new App { Id = 14, Name = "Calorie Counter", Description = "Track your daily calorie intake easily.", CategoryId = 5 },
                new App { Id = 15, Name = "Trivia Master", Description = "Challenge yourself with fun trivia questions.", CategoryId = 4 },
                new App { Id = 16, Name = "Racing Frenzy", Description = "A thrilling racing game with amazing graphics.", CategoryId = 1 },
                new App { Id = 17, Name = "Mindful Meditation", Description = "Guided meditation sessions for relaxation.", CategoryId = 5 },
                new App { Id = 18, Name = "Language Hub", Description = "Learn multiple languages with interactive lessons.", CategoryId = 3 },
                new App { Id = 19, Name = "Budget Tracker", Description = "Manage your expenses and save more.", CategoryId = 2 },
                new App { Id = 20, Name = "Comedy Central", Description = "Watch funny videos and stand-up comedy.", CategoryId = 4 }
            );
        }
    }
}
