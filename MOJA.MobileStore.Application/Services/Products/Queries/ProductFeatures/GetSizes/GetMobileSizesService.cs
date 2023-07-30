using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSizes
{
    public class GetMobileSizesService : IGetMobileSizesService
    {
        private IAppDbContext _db;

        public GetMobileSizesService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetMobileSizeDto>> ExecuteAsync()
        {
            var sizes = await _db.MobileSizes.ToListAsync();
            return sizes.Select(ins => new GetMobileSizeDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
