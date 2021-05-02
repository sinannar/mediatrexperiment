using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherExample.Dtos
{
    public class GetCustomerQueryRequestDto : IRequest<GetCustomerQueryResponseDto>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
