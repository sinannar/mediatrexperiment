using CustomMediator;
using ExampleWithCustomMediator.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithCustomMediator.Handlers
{
    public class GetProductHandler : IRequestHandler<GetCustomerRequestDto, GetCustomerResponseDto>
    {
        public GetProductHandler()
        {

        }

        public Task<GetCustomerResponseDto> Handle(GetCustomerRequestDto request)
        {
            Console.WriteLine("GetProductHandler is being called");
            return Task.FromResult(new GetCustomerResponseDto());
        }
    }
}
