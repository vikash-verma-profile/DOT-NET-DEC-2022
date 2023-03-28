using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElasticKibanaLoggingVerify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElasticSearchController : ControllerBase
    {
        private readonly ILogger<ElasticSearchController> _logger;  
        public ElasticSearchController(ILogger<ElasticSearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int GetRandomValue()
        {
            var random=new Random();
            var randomValue=random.Next(0, 100);
            return randomValue;
        }
        [HttpGet("{id}")]
        public string ThrowErrorMessage(int id)
        {
            try
            {
                if (id <= 0)
                    throw new Exception($"id cannot be less than or equal to 0. value passed is {id}");
                return id.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,ex.Message);
            }
            return string.Empty;
        }
    }
}
