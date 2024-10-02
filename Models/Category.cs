namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; // Adding the Description property
        public string IconPath { get; set; } = string.Empty; // Adding the IconPath property
    }
}
