using AnotherExample.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AnotherExample.Handlers
{
    public class GetCustomerHandler : IRequestHandler<GetCustomerRequestDto, GetCustomerResponseDto>
    {
        public Task<GetCustomerResponseDto> Handle(GetCustomerRequestDto request, CancellationToken cancellationToken)
        {
            Console.WriteLine("GetCustomerHandler is being called");
            return Task.FromResult(new GetCustomerResponseDto());
        }
    }

}
