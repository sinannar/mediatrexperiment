﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherExample.Dtos
{
    public class CreateCustomerCommandRequestDto : IRequest<CreateCustomerCommandResponseDto>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
