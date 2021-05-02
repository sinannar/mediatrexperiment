using CustomMediator;
using ExampleWithCustomMediator.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithCustomMediator.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequestDto, CreateProductResponseDto>
    {
        public CreateProductHandler()
        {

        }

        public Task<CreateProductResponseDto> Handle(CreateProductRequestDto request)
        {
            Console.WriteLine("CreateProductHandler is being called");
            return Task.FromResult(new CreateProductResponseDto());
        }
    }
}
