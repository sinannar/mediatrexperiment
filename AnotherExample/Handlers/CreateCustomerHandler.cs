using AnotherExample.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AnotherExample.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommandRequestDto, CreateCustomerCommandResponseDto>
    {
        public Task<CreateCustomerCommandResponseDto> Handle(CreateCustomerCommandRequestDto request, CancellationToken cancellationToken)
        {
            Console.WriteLine("CreateCustomerHandler is being called");
            return Task.FromResult(new CreateCustomerCommandResponseDto());
        }
    }
}
