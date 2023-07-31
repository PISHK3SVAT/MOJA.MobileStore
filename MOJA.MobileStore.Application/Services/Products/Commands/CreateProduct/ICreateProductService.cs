using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Products.Features;
using MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct.Features;

namespace MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct
{
    public interface ICreateProductService
    {
        Task<ResultCreateProductDto> Execute(CreateProductDto dto);
    }
}
