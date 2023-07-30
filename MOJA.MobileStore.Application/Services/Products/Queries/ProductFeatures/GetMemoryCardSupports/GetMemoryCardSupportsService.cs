using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMemoryCardSupports
{
    public class GetMemoryCardSupportsService : IGetMemoryCardSupportsService
    {
        private IAppDbContext _db;

        public GetMemoryCardSupportsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetMemoryCardSupportDto>> ExecuteAsync()
        {
            var memoryCardSupports = await _db.MemoryCardSupports.ToListAsync();
            return memoryCardSupports.Select(ins => new GetMemoryCardSupportDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
