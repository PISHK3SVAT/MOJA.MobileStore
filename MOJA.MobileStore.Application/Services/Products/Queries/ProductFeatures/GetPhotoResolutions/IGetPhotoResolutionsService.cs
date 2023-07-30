﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetPhotoResolutions
{

    public interface IGetPhotoResolutionsService
    {
        Task<List<GetPhotoResolutionsDto>> ExecuteAsync();
    }
}
