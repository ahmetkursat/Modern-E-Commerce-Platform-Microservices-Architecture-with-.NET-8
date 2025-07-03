using ECommerce.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Infrastructure
{
    public class RabbitMQEventBus : IEventBus
    {
        public async Task PublishAsync<T>(T @event) where T : IDomainEvent
        {


        }
    }
}
