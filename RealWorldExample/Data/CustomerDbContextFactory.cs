using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealWorldExample.Data
{
    public class CustomerDbContextFactory : DesignTimeDbContextFactory<CustomerDbContext>
    {
        protected override CustomerDbContext CreateNewInstance(DbContextOptions<CustomerDbContext> options)
        {
            return new CustomerDbContext(options);
        }
    }
}
