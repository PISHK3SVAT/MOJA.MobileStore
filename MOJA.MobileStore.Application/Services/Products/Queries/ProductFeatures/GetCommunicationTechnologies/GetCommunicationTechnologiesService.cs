using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetCommunicationTechnologies
{
    public class GetCommunicationTechnologiesService : IGetCommunicationTechnologiesService
    {
        private readonly IAppDbContext _db;

        public GetCommunicationTechnologiesService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetCommunicationTechnologiesDto>> ExecuteAsync()
        {
            var backguards = await _db.CommunicationTechnologies.ToListAsync();
            return backguards.Select(bg => new GetCommunicationTechnologiesDto
            {
                Id = bg.Id,
                Title = bg.Title,
            }).ToList();
        }
    }
}
