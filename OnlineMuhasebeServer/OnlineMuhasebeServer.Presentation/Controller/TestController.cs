using Microsoft.AspNetCore.Mvc;
using OnlineMuhasebeServer.Presentation.Abstraction;

namespace OnlineMuhasebeServer.Presentation.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public sealed class TestController : ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("İşlem başarılı");
        }
    }
}
