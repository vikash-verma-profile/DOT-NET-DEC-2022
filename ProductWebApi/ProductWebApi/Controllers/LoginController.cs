using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductWebApi.Models;

namespace ProductWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ProductDb1Context db;
        public LoginController(ProductDb1Context _db)
        {
            db = _db;
        }
        [HttpPost]
        public async Task<IActionResult> Login()
        {
            var products = await db.TblProducts.ToListAsync();
            return Ok(products);
        }
    }
}
