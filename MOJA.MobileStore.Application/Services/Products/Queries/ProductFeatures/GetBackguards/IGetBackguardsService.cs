using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetBackguards
{
    public interface IGetBackguardsService
    {
        Task<List<GetBackguardsDto>> ExecuteAsync();
    }
}
