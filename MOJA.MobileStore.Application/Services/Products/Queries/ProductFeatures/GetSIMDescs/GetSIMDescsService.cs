using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSIMDescs
{
    public class GetSIMDescsService : IGetSIMDescsService
    {
        private IAppDbContext _db;

        public GetSIMDescsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetSIMDescDto>> ExecuteAsync()
        {
            var sIMDescs = await _db.SIMDescs.ToListAsync();
            return sIMDescs.Select(ins => new GetSIMDescDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
