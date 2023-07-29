using Microsoft.EntityFrameworkCore;
using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Domain.Entities.Products;
using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Persistence.Contexts
{
    public class AppDbContext:DbContext,IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerAddress>()
                .HasOne(ca => ca.State)
                .WithMany(s => s.CustomerAddresses)
                .OnDelete(DeleteBehavior.NoAction);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateOnly>()
                .HaveConversion<Converters.DateOnlyConverter>()
                .HaveColumnType("date");

            configurationBuilder.Properties<TimeOnly>()
                .HaveConversion<Converters.TimeOnlyConverter>()
                .HaveColumnType("time");
        }
    }
    
}
