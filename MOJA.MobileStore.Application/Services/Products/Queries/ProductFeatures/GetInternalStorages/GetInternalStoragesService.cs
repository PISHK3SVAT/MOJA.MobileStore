using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetInternalStorages
{
    public class GetInternalStoragesService : IGetInternalStoragesService
    {
        private IAppDbContext _db;

        public GetInternalStoragesService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetInternalStorageDto>> ExecuteAsync()
        {
            var internalStorages = await _db.InternalStorages.ToListAsync();
            return internalStorages.Select(ins => new GetInternalStorageDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
