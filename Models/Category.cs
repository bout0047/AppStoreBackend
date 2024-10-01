namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }

        public required string CategoryName { get; set; }

        public required string IconPath { get; set; }

        // Collection of apps in this category
        public ICollection<App> Apps { get; set; } = new List<App>();
    }
}
