using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSensors
{
    public class GetSensorsService : IGetSensorsService
    {
        private IAppDbContext _db;

        public GetSensorsService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetSensorDto>> ExecuteAsync()
        {
            var sensors = await _db.MobileSensors.ToListAsync();
            return sensors.Select(ins => new GetSensorDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
