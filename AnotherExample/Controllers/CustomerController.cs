using AnotherExample.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherExample.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CustomerController : ControllerBase
    {
        private IMediator _mediator { get; }

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<GetCustomerResponseDto> GetCustomer([FromBody] GetCustomerRequestDto payload)
        {
            return await _mediator.Send(payload);
        }

        [HttpPost]
        public async Task<CreateCustomerResponseDto> CreateCustomer([FromBody] CreateCustomerRequestDto payload)
        {
            return await _mediator.Send(payload);
        }
    }
}
