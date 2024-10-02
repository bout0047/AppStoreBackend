namespace AppStoreBackend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        // Constructor ensures properties are initialized
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
