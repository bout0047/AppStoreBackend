using AppStoreBackend.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreBackend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        Task<CategoryDTO> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(CategoryDTO category);
        Task UpdateCategoryAsync(int id, CategoryDTO category);
        Task DeleteCategoryAsync(int id);
    }
}
