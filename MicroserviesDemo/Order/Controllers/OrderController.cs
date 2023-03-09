using MassTransit;
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
        IBus bus;
        public OrderController(MicroserviceDemoContext _db,IBus _bus)
        {
            db = _db;
            bus = _bus;
        }
        [HttpGet]
        public IEnumerable<TblOrder> GetOrders()
        {
            return db.TblOrders;
        }
        [HttpPost]
        public async Task<IActionResult> PostOrders(TblOrder order)
        {
            db.TblOrders.Add(order);
            db.SaveChanges();
            Uri uri = new Uri("rabbitmq:localhost/OrderQueue");
            var endpoint = await bus.GetSendEndpoint(uri);
            await endpoint.Send(order);
            return Ok(new { Message="Your order is being placed."});
        }
    }
}
