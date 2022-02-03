using Microsoft.AspNetCore.Mvc;

namespace crud_filmes_api_aspnetcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IConfiguration config)
        {
            string environment = config["Ambiente"];

            return StatusCode(200, $"200 OK - Ambiente: {environment}");
        }
    }
}