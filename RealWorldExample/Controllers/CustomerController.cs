using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealWorldExample.Commands;
using RealWorldExample.Dtos;
using RealWorldExample.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Controllers
{
    public class CustomerController : ApiControllerBase

    {
        public CustomerController(IMediator mediator) : base(mediator)
        {
        }

       
        [HttpGet]       
        public async Task<ActionResult<CustomerDto>> GetCustomerAsync(Guid id)
        {
            return Single(await QueryAsync(new GetCustomerQuery { CustomerId = id } ));
        }

       
        [HttpPost]
        public async Task<ActionResult> CreateCustomerAsync([FromBody] CreateCustomerCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}
