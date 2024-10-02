using Microsoft.AspNetCore.Mvc;

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Remove this line if it doesn't exist:
            // SomeMethodThatReturnsVoid(); 

            return Ok();
        }
    }
}
