using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetOSs
{
    public class GetOSsService : IGetOSsService
    {
        private IAppDbContext _db;

        public GetOSsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetOSsDto>> ExecuteAsync()
        {
            var oses = await _db.MobileOSs.ToListAsync();
            return oses.Select(o => new GetOSsDto
            {
                Id = o.Id,
                Title = o.Title,
            }).ToList();
        }
    }
}
