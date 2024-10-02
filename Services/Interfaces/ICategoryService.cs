using System.Threading.Tasks;
using AppStoreBackend.DTOs;

namespace AppStoreBackend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAllCategoriesAsync();
        Task<CategoryDTO?> GetCategoryByIdAsync(int id);
        Task<CategoryDTO> CreateCategoryAsync(CategoryDTO categoryDto);
        Task<CategoryDTO?> UpdateCategoryAsync(int id, CategoryDTO categoryDto);  // Make sure this signature matches
        Task<bool> DeleteCategoryAsync(int id);
    }
}
