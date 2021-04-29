using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Events
{
    public class CustomerCreatedEvent : INotification
    {
        public Guid CustomerId { get; }

        public CustomerCreatedEvent(Guid customerId)
        {
            CustomerId = customerId;
        }
    }
}
