using Newtonsoft.Json;
using RealWorldExample.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Queries
{
    public class GetCustomerQuery : QueryBase<CustomerDto>
    {
        [Required]
        public Guid CustomerId { get; set; }
    }
}
