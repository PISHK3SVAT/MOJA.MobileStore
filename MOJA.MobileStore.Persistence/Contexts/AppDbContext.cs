using Microsoft.EntityFrameworkCore;
using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Domain.Entities.Carts;
using MOJA.MobileStore.Domain.Entities.Products;
using MOJA.MobileStore.Domain.Entities.Products.Features;
using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Persistence.Contexts
{
    public class AppDbContext:DbContext,IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MobileColor> Colors { get; set; }
        public DbSet<BackGuardMaterial> BackGuards { get; set; }
        public DbSet<MobileBrand> MobileBrands { get; set; }
        public DbSet<CommunicationNetwork> CommunicationNetworks { get; set; }
        public DbSet<CommunicationTechnology> CommunicationTechnologies { get; set; }
        public DbSet<InternalStorage> InternalStorages { get; set; }
        public DbSet<MemoryCardSupport> MemoryCardSupports { get; set; }
        public DbSet<MobileCategory> MobileCategories { get; set; }
        public DbSet<MobileTechnology> MobileTechnologies { get; set; }
        public DbSet<MobileOS> MobileOSs { get; set; }
        public DbSet<PhotoResolution> PhotoResolutions { get; set; }
        public DbSet<MobileRam> MobileRams { get; set; }
        public DbSet<RearCamera> RearCameras { get; set; }
        public DbSet<ScreenTechnology> ScreenTechnologies { get; set; }
        public DbSet<MobileSensor> MobileSensors { get; set; }
        public DbSet<SIMDesc> SIMDescs { get; set; }
        public DbSet<MobileSize> MobileSizes { get; set; }
        public DbSet<SpecialFeature> SpecialFeatures { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerAddress>()
                .HasOne(ca => ca.State)
                .WithMany(s => s.CustomerAddresses)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Question>()
                .HasOne(q => q.Customer)
                .WithMany(c => c.Questions)
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
