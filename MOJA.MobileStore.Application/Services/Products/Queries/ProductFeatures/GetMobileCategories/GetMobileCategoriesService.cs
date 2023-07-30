using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileCategories
{
    public class GetMobileCategoriesService : IGetMobileCategoriesService
    {
        private readonly IAppDbContext _db;

        public GetMobileCategoriesService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetMobileCategoryDto>> ExecuteAsync()
        {
            var categories = await _db.MobileCategories.ToListAsync();
            return categories.Select(mc => new GetMobileCategoryDto
            {
                Id = mc.Id,
                Title = mc.Title,
            }).ToList();
        }
    }
}
