using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Events
{
    public class StockReleasedEvent : BaseEvent
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public int ReleasedQuantity { get; set; }

        public int NewStock { get; set; }

        public int OrderId { get; set; }

        public string ReleaseReason { get ; set; } = string.Empty;

        public DateTime ReleasedAt { get; set; } = DateTime.UtcNow;

    }
}
