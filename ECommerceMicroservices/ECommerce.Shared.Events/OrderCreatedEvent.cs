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

        public decimal TotalAmount { get; set; }

        public List<OrderItemData> Items = new();

        public string ShippingAddress { get; set; } = string.Empty;
    }
}
