using MediatR;
using RealWorldExample.Commands;
using RealWorldExample.Dtos;
using RealWorldExample.Dxos;
using RealWorldExample.Events;
using RealWorldExample.Models;
using RealWorldExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RealWorldExample.Services
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICustomerDxos _customerDxos;
        private readonly IMediator _mediator;

        public CreateCustomerHandler(ICustomerRepository customerRepository, IMediator mediator, ICustomerDxos customerDxos)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _customerDxos = customerDxos ?? throw new ArgumentNullException(nameof(customerDxos));
        }


        public async Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            if (await _customerRepository.EmailExistAsync(request.Email))
            {
                throw new ArgumentException($"This email {request.Email} is already existed!", nameof(request.Email));
            }

            var customer = new Customer(request.Name, request.Email, request.Address, request.Age, request.PhoneNumber);

            _customerRepository.Add(customer);

            if (await _customerRepository.SaveChangesAsync() == 0)
            {
                throw new ApplicationException();
            }

            await _mediator.Publish(new CustomerCreatedEvent(customer.Id), cancellationToken);

            var customerDto = _customerDxos.MapCustomerDto(customer);
            return customerDto;
        }
    }
}
