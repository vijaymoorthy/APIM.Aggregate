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

        //[ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
        //[HttpGet]
        //public string Get()
        //{
        //    return $"Hello world from API Two @ {DateTime.Now.ToString("s")}";
        //}

        [ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
        [HttpGet]
        public string Get()
        {
            var rand = new Random();
            return string.Join("", Enumerable.Repeat(0, 50 * 1024).Select(n => (char)rand.Next(127)));
        }
    }
}