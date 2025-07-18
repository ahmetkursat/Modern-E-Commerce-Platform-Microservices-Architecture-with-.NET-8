﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.Events
{
    public interface IEventHandler<T> where T : IDomainEvent
    {
        Task Handle(T @event);
    }
}
