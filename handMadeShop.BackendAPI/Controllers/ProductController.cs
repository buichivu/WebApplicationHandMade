using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace handMadeShop.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Test ok");
        }
    }
}
