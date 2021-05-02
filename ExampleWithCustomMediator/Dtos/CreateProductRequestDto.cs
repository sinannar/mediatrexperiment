using CustomMediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithCustomMediator.Dtos
{
    public class CreateProductRequestDto : IRequest<CreateProductResponseDto>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
