using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Domain.Entities.Products;

namespace MOJA.MobileStore.Persistence.Contexts
{
    public class AppDbContext:DbContext,IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Product> Products { get; set; }
    }
    
}
