using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithCustomMediator.Dtos
{
    public class GetCustomerResponseDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
