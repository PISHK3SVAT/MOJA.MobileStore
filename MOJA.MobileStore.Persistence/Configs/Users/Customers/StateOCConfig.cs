using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Persistence.Configs.Users.Customers
{
    internal class StateOCConfig : IEntityTypeConfiguration<StateOC>
    {
        public void Configure(EntityTypeBuilder<StateOC> builder)
        {
            builder.Property(s => s.Title)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasMany<CustomerAddress>()
                .WithOne(ca => ca.State)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
