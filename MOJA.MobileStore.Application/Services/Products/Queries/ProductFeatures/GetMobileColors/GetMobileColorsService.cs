using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileColors
{
    public class GetMobileColorsService : IGetMobileColorsService
    {
        private readonly IAppDbContext _db;

        public GetMobileColorsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetMobileColorsDto>> ExecuteAsync()
        {
            var colors = await _db.Colors.ToListAsync();
            return colors.Select(c => new GetMobileColorsDto
            {
                Id = c.Id,
                Title = c.Title
            }).ToList();
        }
    }

}
