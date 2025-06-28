using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Events
{
    public abstract class BaseEvent :IDomainEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime OccurredAt { get; set; } = DateTime.UtcNow;

        public string EventType => GetType().Name;
    }
}
