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
        public async Task Handle(OrderCreatedEvent @event)
        {
            Console.WriteLine($"Order Created: {@event.OrderId} for User: {@event.UserId}");

            // Burada başka servislerle konuşabilirsin
            // Örn: Stock reserve, Payment başlat vs.

            await Task.CompletedTask;
        }
    }
}
