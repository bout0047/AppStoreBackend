using AppStoreBackend.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStoreBackend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        Task<CategoryDTO> GetCategoryByIdAsync(int id);
        Task<CategoryDTO> CreateCategoryAsync(CategoryDTO categoryDTO);
        Task<CategoryDTO> UpdateCategoryAsync(int id, CategoryDTO categoryDTO);
        Task<bool> DeleteCategoryAsync(int id);
    }
}
