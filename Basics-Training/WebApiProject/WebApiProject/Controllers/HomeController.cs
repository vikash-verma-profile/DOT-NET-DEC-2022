using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        DemoAdoDBContext db = new DemoAdoDBContext();
        [HttpGet]
        public IEnumerable<TblSample> Get()
        {
            return db.TblSamples;
        }
        [HttpPost]
        public IActionResult Post([FromBody] TblSample sample)
        {
            db.TblSamples.Add(sample);
            db.SaveChanges();
            return Ok("Record is being saved successfully");
        }
        [HttpPut]
        public string Put([FromBody] string text)
        {
            return "Hi I am first Response";
        }
        [HttpDelete]
        public string Delete(int id)
        {
            return "Hi I am first Response";
        }
    }
}
