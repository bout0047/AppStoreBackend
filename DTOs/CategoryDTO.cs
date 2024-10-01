public class CategoryDTO
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string IconPath { get; set; }
    public ICollection<AppDTO> Apps { get; set; }
}
