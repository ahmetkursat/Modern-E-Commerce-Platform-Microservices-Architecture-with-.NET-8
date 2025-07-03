using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Domain
{
    public enum OrderStatus
    {
        Created = 1,
        PaymentPending = 2,
        PaymentCompleted = 3,
        StockReserved = 4,
        Processing = 5,
        Shipped = 6,
        Delivered = 7,
        Cancelled = 8,
        Refunded = 9
    }
}
