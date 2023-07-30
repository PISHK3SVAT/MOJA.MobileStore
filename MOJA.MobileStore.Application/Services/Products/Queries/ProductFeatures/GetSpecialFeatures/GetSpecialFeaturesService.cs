using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSpecialFeatures
{
    public class GetSpecialFeaturesService : IGetSpecialFeaturesService
    {
        private IAppDbContext _db;

        public GetSpecialFeaturesService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetSpecialFeatureDto>> ExecuteAsync()
        {
            var specialFeatures = await _db.SpecialFeatures.ToListAsync();
            return specialFeatures.Select(ins => new GetSpecialFeatureDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
