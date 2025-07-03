using ECommerce.Shared.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ECommerce.Shared.Infrastructure
{
    public class RabbitMQEventBus : IEventBus
    {
        public async Task PublishAsync<T>(T @event) where T : IDomainEvent
        {
            // Şimdilik console'a yazdır, sonra RabbitMQ ekleriz
            var json = JsonSerializer.Serialize(@event);
            Console.WriteLine($"Event Published: {typeof(T).Name} - {json}");

            await Task.CompletedTask;
        }

        public async Task SubscribeAsync<T>(Func<T, Task> handler) where T : IDomainEvent
        {
            // RabbitMQ subscription logic buraya gelecek
            await Task.CompletedTask;
        }
    }
}
