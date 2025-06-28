using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Events
{
    public class ProductCreatedEvent : BaseEvent
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string CategoryName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string CreatedBy { get; set; } = string.Empty;

    }
}
