using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MOJA.MobileStore.Domain.Users;

namespace MOJA.MobileStore.Persistence.Configs.Users
{
    internal class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.Family)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasIndex(p => p.NationalCode)
                .IsUnique();
            builder.Property(p => p.NationalCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsFixedLength();
        }
    }
}
