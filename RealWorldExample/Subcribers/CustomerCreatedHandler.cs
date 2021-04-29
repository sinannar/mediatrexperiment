﻿using MediatR;
using Microsoft.Extensions.Logging;
using RealWorldExample.Events;
using RealWorldExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RealWorldExample.Subcribers
{
    public class CustomerCreatedHandler : INotificationHandler<CustomerCreatedEvent>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ILogger _logger;

        public CustomerCreatedHandler(ICustomerRepository customerRepository, ILogger<CustomerCreatedHandler> logger)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _logger = logger;
        }

        public async Task Handle(CustomerCreatedEvent notification, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetAsync(e => e.Id == notification.CustomerId);

            if (customer == null)
            {
                //TODO: Handle next business logic if customer is not found
                _logger.LogWarning("Customer is not found by customer id from publisher");
            }
            else
            {
                _logger.LogInformation($"Customer has found by customer id: {notification.CustomerId} from publisher");
            }
        }
    }
}
