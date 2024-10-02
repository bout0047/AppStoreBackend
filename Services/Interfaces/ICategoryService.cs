using System.Collections.Generic;
using System.Threading.Tasks;
using AppStoreBackend.DTOs;

namespace AppStoreBackend.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetAllCategoriesAsync();
        Task<CategoryDTO> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(CategoryDTO categoryDto);
        Task UpdateCategoryAsync(int id, CategoryDTO categoryDto);
        Task DeleteCategoryAsync(int id);
    }
}
