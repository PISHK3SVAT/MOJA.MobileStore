using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetBrands
{
    public interface IGetBrandsService
    {
        Task<List<GetBrandsDto>> ExecuteAsync();
    }
}
