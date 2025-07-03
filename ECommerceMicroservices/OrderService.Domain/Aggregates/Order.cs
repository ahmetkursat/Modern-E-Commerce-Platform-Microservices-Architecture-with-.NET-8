using ECommerce.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain.Aggregates
{
    public class Order : AggregateRoot
    {
        public int Id { get; private set; }

        public int UserId { get; private set; }

        public OrderStatus Status { get; private set; }

        public static Order Create(int userId)
        {
            var order = new Order { UserId = userId, Status = OrderStatus.Created};

            order.AddDomainEvent(new OrderCreatedEvent
            {
                OrderId = order.Id,
                UserId = userId,
                CreatedAt = DateTime.UtcNow
            });

            return order;

        }
    


    }
}
