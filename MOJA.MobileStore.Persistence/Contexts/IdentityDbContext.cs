using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Domain.Users;

namespace MOJA.MobileStore.Persistence.Contexts
{
    public class IdentityDbContext:IdentityDbContext<Person>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
        :base(options)
        {}
    }
}
