using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.DTOs;
using AppStoreBackend.Services.Interfaces;
using System.Threading.Tasks;
using AppStoreBackend.Services;

namespace AppStoreBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppsController : ControllerBase
    {
        private readonly IAppService _appService;

        public AppsController(IAppService appService)
        {
            _appService = appService;
        }

        // POST: api/Apps
        [HttpPost]
        public async Task<IActionResult> CreateApp([FromBody] AppDTO appDto)
        {
            if (appDto == null)
            {
                return BadRequest("App data must be provided");
            }

            await _appService.CreateAppAsync(appDto);  // Removed var assignment as the method returns void
            return Ok("App created successfully");
        }

        // PUT: api/Apps/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApp(int id, [FromBody] AppDTO appDto)
        {
            if (appDto == null)
            {
                return BadRequest("App data must be provided");
            }

            await _appService.UpdateAppAsync(id, appDto);  // Removed var assignment as the method returns void
            return Ok("App updated successfully");
        }

        // GET: api/Apps
        [HttpGet]
        public async Task<IActionResult> GetAllApps()
        {
            var apps = await _appService.GetAllAppsAsync();
            return Ok(apps);
        }

        // DELETE: api/Apps/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApp(int id)
        {
            await _appService.DeleteAppAsync(id);  // Removed var assignment as the method returns void
            return Ok("App deleted successfully");
        }
    }
}
