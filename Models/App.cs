namespace AppStoreBackend.Models
{
    public class App
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        // Modify the navigation properties to be nullable
        public Category? Category { get; set; }
    }
}
