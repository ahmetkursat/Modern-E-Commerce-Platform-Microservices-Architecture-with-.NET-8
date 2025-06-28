using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Events
{
    public class StockReservedEvent : BaseEvent
    {
        public int ProductId { get; set; }
        
        public string ProductName { get; set; } = string.Empty;

        public int ReservedQuantity { get; set; }

        public int RemainingStock { get; set; }

        public int OrderId { get; set; }

        public int UserId { get; set; }

        public DateTime ReservedAt { get; set; } = DateTime.UtcNow;

        public TimeSpan ReservationTimeout { get; set; } = TimeSpan.FromMinutes(15);
    }
}
