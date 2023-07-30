using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetScreenTechnologies
{
    public class GetScreenTechnologiesService : IGetScreenTechnologiesService
    {
        private IAppDbContext _db;

        public GetScreenTechnologiesService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetScreenTechnologiyDto>> ExecuteAsync()
        {
            var screenTech = await _db.ScreenTechnologies.ToListAsync();
            return screenTech.Select(ins => new GetScreenTechnologiyDto
            {
                Id = ins.Id,
                Title = ins.Title
            }).ToList();
        }
    }
}
