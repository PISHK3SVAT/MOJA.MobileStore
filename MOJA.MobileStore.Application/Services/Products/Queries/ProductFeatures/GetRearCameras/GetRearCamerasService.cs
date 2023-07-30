using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetRearCameras
{
    public class GetRearCamerasService : IGetRearCamerasService
    {
        private IAppDbContext _db;

        public GetRearCamerasService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetRearCameraDto>> ExecuteAsync()
        {
            var rearCameras = await _db.RearCameras.ToListAsync();
            return rearCameras.Select(ins => new GetRearCameraDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
