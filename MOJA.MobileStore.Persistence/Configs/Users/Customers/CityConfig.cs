using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Persistence.Configs.Users.Customers
{
    internal class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
