namespace AppStoreBackend.DTOs
{
    public class AppDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }  // Added 'required' modifier
        public required string Description { get; set; }  // Added 'required' modifier
        public required string CategoryName { get; set; }  // Added 'required' modifier
    }
}
