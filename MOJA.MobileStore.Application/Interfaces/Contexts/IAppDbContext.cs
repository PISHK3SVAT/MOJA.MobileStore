using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Domain.Entities.Products;
using MOJA.MobileStore.Domain.Entities.Products.Features;

namespace MOJA.MobileStore.Application.Interfaces.Contexts
{
    public interface IAppDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<MobileColor> Colors { get; set; }
        DbSet<BackGuardMaterial> BackGuards { get; set; }
        DbSet<MobileBrand> MobileBrands { get; set; }
        DbSet<CommunicationNetwork> CommunicationNetworks { get; set; }
        DbSet<CommunicationTechnology> CommunicationTechnologies { get; set; }
        DbSet<InternalStorage> InternalStorages { get; set; }
        DbSet<MemoryCardSupport> MemoryCardSupports { get; set; }
        DbSet<MobileCategory> MobileCategories { get; set; }
        DbSet<MobileTechnology> MobileTechnologies { get; set; }
        DbSet<MobileOS> MobileOSs { get; set; }
        DbSet<PhotoResolution> PhotoResolutions { get; set; }
        DbSet<MobileRam> MobileRams { get; set; }
        DbSet<RearCamera> RearCameras { get; set; }
        DbSet<ScreenTechnology> ScreenTechnologies { get; set; }
        DbSet<MobileSensor> MobileSensors { get; set; }
        DbSet<SIMDesc> SIMDescs { get; set; }
        DbSet<MobileSize> MobileSizes { get; set; }
        DbSet<SpecialFeature> SpecialFeatures { get; set; }
        
        
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
