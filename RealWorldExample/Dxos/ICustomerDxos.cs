using RealWorldExample.Dtos;
using RealWorldExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Dxos
{
    public interface ICustomerDxos
    {
        CustomerDto MapCustomerDto(Customer customer);
    }
}
