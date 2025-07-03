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
        public int ProductId { get; private set; }  // ✅ Eksik olan
        public int Quantity { get; private set; }   // ✅ Eksik olan
        public decimal Price { get; private set; }  // ✅ Eksik olan
        public OrderStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }  // ✅ Eksik olan

        private Order() { } // EF Core için

        public static Order Create(int userId, int productId, int quantity, decimal price)  // ✅ Parametreleri ekle
        {
            var order = new Order
            {
                UserId = userId,
                ProductId = productId,    // ✅ Yeni
                Quantity = quantity,      // ✅ Yeni
                Price = price,           // ✅ Yeni
                Status = OrderStatus.Created,
                CreatedAt = DateTime.UtcNow  // ✅ Yeni
            };

            order.AddDomainEvent(new OrderCreatedEvent
            {
                OrderId = order.Id,
                UserId = userId,
                ProductId = productId,    // ✅ Artık eşleşiyor
                Quantity = quantity,      // ✅ Artık eşleşiyor
                Price = price,           // ✅ Artık eşleşiyor
                CreatedAt = DateTime.UtcNow  // ✅ CreatedAt değil, OccurredOn kullan
            });

            return order;
        }
    }



}

