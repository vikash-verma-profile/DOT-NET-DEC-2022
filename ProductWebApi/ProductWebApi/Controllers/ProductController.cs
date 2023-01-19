using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductWebApi.Models;

namespace ProductWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductDb1Context db;
        public ProductController(ProductDb1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var products = await db.TblProducts.ToListAsync();
            return Ok(products);    
        }
    }
}
