using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Domain.Users;
using MOJA.MobileStore.Persistence.Configs.Users;

namespace MOJA.MobileStore.Persistence.Contexts
{
    public class IdentityDbContext:IdentityDbContext<Person>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
        :base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new PersonConfig().Configure(builder.Entity<Person>());
        }
    }
}
