using CustomMediator;
using ExampleWithCustomMediator.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWithCustomMediator.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private IMediator _mediator { get; }

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<CreateProductResponseDto> GetProduct([FromBody] CreateProductRequestDto payload)
        {
            return await _mediator.Send(payload);
        }

        [HttpPost]
        public async Task<GetCustomerResponseDto> CreateProduct([FromBody] GetCustomerRequestDto payload)
        {
            return await _mediator.Send(payload);
        }

    }
}
