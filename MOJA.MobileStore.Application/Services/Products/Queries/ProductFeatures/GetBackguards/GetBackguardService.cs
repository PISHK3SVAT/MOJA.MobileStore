using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetBackguards
{
    public class GetBackguardService : IGetBackguardsService
    {
        private readonly IAppDbContext _db;

        public GetBackguardService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetBackguardsDto>> ExecuteAsync()
        {
            var backguards = await _db.BackGuards.ToListAsync();
            return backguards.Select(bg => new GetBackguardsDto
            {
                Id = bg.Id,
                Title = bg.Title,
            }).ToList();
        }
    }
}
