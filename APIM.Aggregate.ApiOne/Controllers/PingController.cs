using Microsoft.AspNetCore.Mvc;

namespace APIM.Aggregate.ApiOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return $"Hello world from API One @ {DateTime.Now.ToString("s")}";
        }
    }
}