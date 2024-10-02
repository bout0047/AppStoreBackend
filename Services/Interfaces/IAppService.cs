using AppStoreBackend.DTOs;

namespace AppStoreBackend.Services
{
    public interface IAppService
    {
        Task<IEnumerable<AppDTO>> GetAllAppsAsync();
        Task<AppDTO> GetAppByIdAsync(int id);
        Task CreateAppAsync(AppDTO appDto);
        Task UpdateAppAsync(int id, AppDTO appDto);
        Task DeleteAppAsync(int id);
    }
}
