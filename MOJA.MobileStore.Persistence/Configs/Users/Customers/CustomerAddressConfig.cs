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
    internal class CustomerAddressConfig : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.ToTable("Addresses", "Customer");
            builder.Property(ca => ca.Address)
                .IsRequired();

            builder.Property(ca => ca.Plaque)
                .IsRequired();

            builder.Property(ca => ca.PostalCode)
                .IsRequired();
        }
    }
}
