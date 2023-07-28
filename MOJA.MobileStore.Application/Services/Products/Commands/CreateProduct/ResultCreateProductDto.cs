using MOJA.MobileStore.Common.Dtos;

namespace MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct
{
    public class ResultCreateProductDto : BaseResultDto
    {
        public ResultCreateProductDto(bool isSuccessed, string message) : base(isSuccessed, message)
        {
        }
    }
}
