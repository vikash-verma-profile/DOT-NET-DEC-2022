using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductWebApi.Models;
using ProductWebApi.ViewModel;

namespace ProductWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
        [HttpGet]
        [Route("get-product-by-id")]
        public async Task<IActionResult> GetProductByIdAsync(int id)
        {
            var product = await db.TblProducts.FindAsync(id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(TblProduct tblProduct)
        {
            db.TblProducts.Add(tblProduct);
            await db.SaveChangesAsync();
            return Created($"/get-product-by-id?id={tblProduct.Id}",tblProduct);
        }
        [HttpPut]
        public async Task<IActionResult> PutAsync(TblProduct productToUpdate)
        {
            db.TblProducts.Update(productToUpdate);
            await db.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var productsToDelete = await db.TblProducts.FindAsync(id);
            if (productsToDelete == null)
            {
                return NotFound(new ResponseViewModel { Status=200,Message="Product is not available"});
            }
            db.TblProducts.Remove(productsToDelete);
            await db.SaveChangesAsync();
            return NoContent();
        }
    }
}
