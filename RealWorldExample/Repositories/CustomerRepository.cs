using Microsoft.EntityFrameworkCore;
using RealWorldExample.Data;
using RealWorldExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> EmailExistAsync(string email)
        {
            return await ModelDbSets.AsNoTracking().AnyAsync(e => e.Email.Equals(email));

        }
    }
}
