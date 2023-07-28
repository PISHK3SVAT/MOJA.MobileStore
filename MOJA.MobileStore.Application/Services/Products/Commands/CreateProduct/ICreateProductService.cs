using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Products.Features;
using MOJA.MobileStore.Domain.Entities.Products;

namespace MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct
{
    internal interface ICreateProductService
    {
        Task<ResultCreateProductDto> Execute(CreateProductDto dto);
    }
    public class CreateProductService : ICreateProductService
    {
        private IAppDbContext _db;

        public CreateProductService(IAppDbContext db)
        {
            _db = db;
        }

        public async Task<ResultCreateProductDto> Execute(CreateProductDto dto)
        {
            if (!_CreateProductValidation(dto, out string message))
                return new ResultCreateProductDto(true, message);
            var product = MapperProductCreateProductDto.To(dto);
            _db.Products.Add(product);
            var saveResult = await _db.SaveChangesAsync();
            return saveResult==0? new ResultCreateProductDto(false,"مشکلی پیش آمده، دوباره تلاش کنید"):
                new ResultCreateProductDto(true, "محصول با موفقیت ایجاد شد.");
        }

        private bool _CreateProductValidation(CreateProductDto dto, out string message)
        {
            if (!dto.Colors.Any())
            {
                message = "رنگ محصول را وارد کنید";
                return false;
            }
            if (!string.IsNullOrEmpty(dto.Introduction))
            {
                message = "توضیحات محصول را وارد کنید";
                return false;
            }
            if (!_validateProductFeatureId(dto.BrandId,"برند", out message))
                return false;
            if (!_validateNumericalProductFeature(dto.Length, "طول", out message))
                return false;
            if (!_validateNumericalProductFeature(dto.Height, "ارتفاع", out message))
                return false;
            if (!_validateNumericalProductFeature(dto.Width, "عرض", out message))
                return false;
            if (!_validateNumericalProductFeature(dto.Weight, "وزن", out message))
                return false;
            if (!_validateProductFeatureId(dto.ScreenTechId, "فناوری صفحه‌نمایش", out message))
                return false;
            if (!_validateProductFeatureId(dto.SizeId, "اندازه", out message))
                return false;
            if (!_validateProductFeatureId(dto.ScreenResolutionHeight, "ارتفاع رزلوشن", out message))
                return false;
            if (!_validateProductFeatureId(dto.ScreenResolutionLenght, "طول رزلوشن", out message))
                return false;
            if (!_validateProductFeatureId(dto.ScreenPixelsPerInch, "تراکم پیکسلی", out message))
                return false;
            if (!_validateProductFeatureId(dto.SIMDescId, "توضیحات سیم کارت", out message))
                return false;
            if (!_validateProductFeatureId(dto.SIMCardNumber, "تعداد سیم کارت", out message))
                return false;
            if (!_validateTextualProductFeature(dto.BodyStructure, "ساختار بدنه",out message))
                return false;
            if (!dto.SpecialFeatures.Any())
            {
                message = "ویژگی‌های خاص را وارد کنید";
                return false;
            }

            // other property validtion goes this way
            message = string.Empty;
            return true;
        }
        private bool _validateTextualProductFeature(string x, string name, out string message)
        {
            if (!string.IsNullOrEmpty(x))
            {
                message = $"{name} محصول را وارد کنید";
                return false;
            }
            message = string.Empty;
            return true;
        }
        private bool _validateNumericalProductFeature(int x, string name, out string message)
        {
            if (x < 0)
            {
                message = $"${name}نمیتواند منفی باشد";
                return false;
            }
            message = string.Empty;
            return true;
        }
        private bool _validateNumericalProductFeature(float x, string name, out string message)
        {
            if (x < 0)
            {
                message = $"${name}نمیتواند منفی باشد";
                return false;
            }
            message = string.Empty;
            return true;
        }
        private bool _validateProductFeatureId(int x, string name, out string message)
        {
            if (x == 0)
            {
                message = $"${name}را وارد کنید";
                return false;
            }
            if (x < 0)
            {
                message = $"${name}نمیتواند منفی باشد";
                return false;
            }
            message=string.Empty;
            return true;
        }
    }
}
