using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetCommunicationTechnologies
{
    public interface IGetCommunicationTechnologiesService
    {
        Task<List<GetCommunicationTechnologiesDto>> ExecuteAsync();
    }
}
