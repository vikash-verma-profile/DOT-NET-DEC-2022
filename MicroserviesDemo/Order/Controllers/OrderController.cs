using MicroservicesModel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        MicroserviceDemoContext db;
        public OrderController(MicroserviceDemoContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblOrder> GetOrders()
        {
            return db.TblOrders;
        }
        [HttpPost]
        public IActionResult PostOrders(TblOrder order)
        {
            db.TblOrders.Add(order);
            db.SaveChanges();
            return Ok(new { Message="Your order is being placed."});
        }
    }
}
