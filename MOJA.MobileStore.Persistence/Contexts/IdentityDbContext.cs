using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MOJA.MobileStore.Domain.Entities.Users;
using MOJA.MobileStore.Domain.Entities.Users.Customers;
using MOJA.MobileStore.Persistence.Configs.Users;
using MOJA.MobileStore.Persistence.Configs.Users.Customers;

namespace MOJA.MobileStore.Persistence.Contexts
{
    public class IdentityDbContext:IdentityDbContext<Person>
    {
        public DbSet<Customer> Customers { get; set; }
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
        :base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new CityConfig().Configure(builder.Entity<City>());
            new StateOCConfig().Configure(builder.Entity<StateOC>());
            new CustomerAddressConfig().Configure(builder.Entity<CustomerAddress>());
            new PersonConfig().Configure(builder.Entity<Person>());
        }
    }
}
