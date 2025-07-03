using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Events
{
    public class OrderCreatedEvent : BaseEvent
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }  // Eksik
        public int Quantity { get; set; }   // Eksik
        public decimal Price { get; set; }  // Eksik

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
