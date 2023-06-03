using Microsoft.AspNetCore.Mvc;

namespace Panda.SOS.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class PhonesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("salve");
        }
    }
}
