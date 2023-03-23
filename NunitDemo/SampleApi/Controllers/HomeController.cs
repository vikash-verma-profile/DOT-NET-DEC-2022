using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        DbSampleContext db;
        public HomeController()
        {

        }
        public HomeController(DbSampleContext _db)
        {
            db = _db;
        }
        [Route("/get-name")]
        [HttpGet]
        public string GetUserName(int Id)
        {
            return db.TblSamples.Where(x=>x.Id==Id).FirstOrDefault().Name;
        }
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
