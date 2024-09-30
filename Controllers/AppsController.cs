﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppStoreBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // This maps the controller to "api/app"
    public class AppController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllApps()
        {
            var apps = new List<object>
            {
                new { Id = 1, Name = "Sample App 1", Description = "This is a sample app" },
                new { Id = 2, Name = "Sample App 2", Description = "This is another sample app" }
            };

            return Ok(apps); // Returns the list of apps
        }
    }
}
