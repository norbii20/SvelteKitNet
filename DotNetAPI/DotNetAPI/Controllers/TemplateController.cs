using Microsoft.AspNetCore.Mvc;

namespace DotNetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class TemplateController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetRandomNumber()
        {
            return Ok(new Random().Next(0, 100));
        }
    }
}