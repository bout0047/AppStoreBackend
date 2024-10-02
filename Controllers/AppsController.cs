// File: Controllers/AppsController.cs
using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Services;
using System.Threading.Tasks;
using AppStoreBackend.Models;

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppsController : ControllerBase
    {
        private readonly IAppService _appService;

        public AppsController(IAppService appService)
        {
            _appService = appService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var apps = await _appService.GetAllAppsAsync();
            return Ok(apps);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var app = await _appService.GetAppByIdAsync(id);
            if (app == null) return NotFound();
            return Ok(app);
        }

        [HttpPost]
        public async Task<IActionResult> Create(App app)
        {
            var createdApp = await _appService.CreateAppAsync(app);
            return CreatedAtAction(nameof(GetById), new { id = createdApp.Id }, createdApp);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, App app)
        {
            if (id != app.Id) return BadRequest();
            await _appService.UpdateAppAsync(app);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _appService.DeleteAppAsync(id);
            return NoContent();
        }
    }
}
