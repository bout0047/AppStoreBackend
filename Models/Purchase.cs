namespace AppStoreBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public User? User { get; set; } // Changed to nullable to avoid warning
        public App? App { get; set; }   // Changed to nullable to avoid warning
    }
}
