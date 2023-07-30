using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetRams
{
    public class GetMobileRamsService : IGetMobileRamsService
    {
        private IAppDbContext _db;

        public GetMobileRamsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetMobileRamDto>> ExecuteAsync()
        {
            var rams = await _db.MobileRams.ToListAsync();
            return rams.Select(ins => new GetMobileRamDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
