using Microsoft.AspNetCore.Mvc;
using AppStoreBackend.Services.Interfaces;
using AppStoreBackend.DTOs;
using AppStoreBackend.Models;
using System.Threading.Tasks;
using AppStoreBackend.Services;

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

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApp(int id, [FromBody] AppDTO appDto)
        {
            if (appDto == null)
            {
                return BadRequest("App data is required");
            }

            await _appService.UpdateAppAsync(id, appDto);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateApp([FromBody] AppDTO appDto)
        {
            if (appDto == null)
            {
                return BadRequest("App data is required");
            }

            await _appService.CreateAppAsync(appDto);
            return CreatedAtAction(nameof(GetAppById), new { id = appDto.Id }, appDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppById(int id)
        {
            var app = await _appService.GetAppByIdAsync(id);
            if (app == null)
            {
                return NotFound();
            }

            return Ok(app);
        }
    }
}
