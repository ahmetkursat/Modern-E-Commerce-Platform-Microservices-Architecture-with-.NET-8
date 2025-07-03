using ECommerce.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Application
{
    public class OrderCreatedEventHandler : IEventHandler<OrderCreatedEvent>
    {
        public Task Handle(OrderCreatedEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
