using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Common.Dtos;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileColors
{
    public interface IGetMobileColorsService
    {
        Task<List<GetMobileColorsDto>> ExecuteAsync();
    }

}
