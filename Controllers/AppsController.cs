using AppStoreBackend.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AppsController : ControllerBase
{
    private readonly IAppService _appService;

    public AppsController(IAppService appService)
    {
        _appService = appService;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteApp(int id)
    {
        // Call DeleteAppAsync and store the result
        bool result = await _appService.DeleteAppAsync(id);

        // Check if the delete operation was successful
        if (!result)
        {
            return NotFound("App not found or could not be deleted.");
        }

        // If successful, return success message
        return Ok("App deleted successfully.");
    }
}
