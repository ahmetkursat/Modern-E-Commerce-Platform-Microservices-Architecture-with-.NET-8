using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Events
{
    public class PaymentFailedEvent
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string FailureReason { get; set; } = string.Empty;
        public DateTime FailedAt { get; set; } = DateTime.UtcNow;
        public string TransactionId { get; set; } = string.Empty;

    }
}
