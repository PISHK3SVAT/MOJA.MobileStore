using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileCategories
{
    public interface IGetMobileCategoriesService
    {
        Task<List<GetMobileCategoryDto>> ExecuteAsync();
    }
}
