using RealWorldExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<bool> EmailExistAsync(string email);
    }
}
