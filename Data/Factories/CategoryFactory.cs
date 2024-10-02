namespace AppStoreBackend.Data.Factories
{
    using AppStoreBackend.DTOs;
    using AppStoreBackend.Models;

    public class CategoryFactory
    {
        public static Category CreateCategory(CategoryDTO categoryDto)
        {
            return new Category
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                Description = categoryDto.Description,
                IconPath = categoryDto.IconPath // Add IconPath here
            };
        }
    }
}
