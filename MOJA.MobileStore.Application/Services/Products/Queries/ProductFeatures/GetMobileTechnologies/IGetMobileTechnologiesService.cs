using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Common.Dtos;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileTechnologies
{
    public interface IGetMobileTechnologiesService
    {
        Task<List<GetMobileTechnologiesDto>> ExecuteAsync();
    }
    public class GetMobileTechnologiesService : IGetMobileTechnologiesService
    {
        private readonly IAppDbContext _db;

        public GetMobileTechnologiesService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<List<GetMobileTechnologiesDto>> ExecuteAsync()
        {
            var mobileTechs = await _db.MobileTechnologies.ToListAsync();
            return mobileTechs.Select(mt => new GetMobileTechnologiesDto
            {
                Id = mt.Id,
                Title = mt.Title,
            }).ToList();
        }
    }

    public class GetMobileTechnologiesDto : BaseGetProductFeaturesDto { }
}
