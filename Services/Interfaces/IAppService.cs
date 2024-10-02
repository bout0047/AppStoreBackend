using System.Collections.Generic;
using System.Threading.Tasks;
using AppStoreBackend.DTOs;

namespace AppStoreBackend.Services
{
    public interface IAppService
    {
        Task<IEnumerable<AppDTO>> GetAllAppsAsync();
        Task<AppDTO> GetAppByIdAsync(int id);
        Task CreateAppAsync(AppDTO app);
        Task UpdateAppAsync(int id, AppDTO app);
        Task DeleteAppAsync(int id);
    }
}
