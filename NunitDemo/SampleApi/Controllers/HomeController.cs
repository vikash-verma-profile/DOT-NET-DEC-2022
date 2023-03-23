using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string GetEmployeeName(int empId)
        {
            string name;
            if (empId==1)
            {
                name = "Vikash";
            }
            else if (empId == 2)
            {
                name = "Rahul";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}
