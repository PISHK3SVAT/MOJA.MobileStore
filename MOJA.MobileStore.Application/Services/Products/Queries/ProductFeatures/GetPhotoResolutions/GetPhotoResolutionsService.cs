using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetPhotoResolutions
{
    public class GetPhotoResolutionsService : IGetPhotoResolutionsService
    {
        private IAppDbContext _db;

        public GetPhotoResolutionsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetPhotoResolutionsDto>> ExecuteAsync()
        {
            var phr = await _db.PhotoResolutions.ToListAsync();
            return phr.Select(ins => new GetPhotoResolutionsDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
