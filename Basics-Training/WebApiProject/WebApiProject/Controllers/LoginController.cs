using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject.Models;
using WebApiProject.ViewModel;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        DemoAdoDBContext db = new DemoAdoDBContext();
        [HttpPost]
        public IActionResult Post([FromBody] TblLogin login)
        {
            var result = db.TblLogins.Where(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();
            return Ok(new Response { Status=200,Message="Either your UserName or Password is wrong" });
        }
    }
}
