using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Test.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(ILogger<HomeController> logger)
        {
        }

        [HttpGet("/api/Test")]
        [Authorize]
        public IActionResult Test()
        {
            return Ok(new { success = true });
        }
    }
}
