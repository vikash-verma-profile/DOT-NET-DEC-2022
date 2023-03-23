using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        private readonly ILogger _logger;
        public TestingController(ILogger<TestingController> logger)
        {
            _logger= logger;    
        }
        [HttpGet]
        public string GetMessage()
        {
            _logger.LogDebug("Test Method is getting Called!!");
            return "Hi ! Tester";
        }
    }
}
