using MassTransit;
using MicroservicesModel.Models;

namespace Catalog.Consumer
{
    public class OrderConsumer:IConsumer<TblOrder>
    {
        public Task Consume(ConsumeContext<TblOrder> context)
        {
            var data = context.Message;
            return Task.CompletedTask;
        }
    }
}
