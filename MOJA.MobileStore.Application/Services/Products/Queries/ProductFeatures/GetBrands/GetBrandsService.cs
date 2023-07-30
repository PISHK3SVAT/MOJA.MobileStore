using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetBrands
{
    public class GetBrandsService : IGetBrandsService
    {
        private readonly IAppDbContext _db;

        public GetBrandsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetBrandsDto>> ExecuteAsync()
        {
            var brands = await _db.MobileBrands.ToListAsync();
            return brands.Select(bg => new GetBrandsDto
            {
                Id = bg.Id,
                Title = bg.Title,
            }).ToList();
        }
    }
}
