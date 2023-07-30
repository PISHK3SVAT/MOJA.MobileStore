using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetCommunicationNetworks
{
    public class GetCommunicationNetworksService : IGetCommunicationNetworksService
    {
        private readonly IAppDbContext _db;

        public GetCommunicationNetworksService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetCommunicationNetworksDto>> ExecuteAsync()
        {
            var brands = await _db.CommunicationNetworks.ToListAsync();
            return brands.Select(bg => new GetCommunicationNetworksDto
            {
                Id = bg.Id,
                Title = bg.Title,
            }).ToList();
        }
    }
}
