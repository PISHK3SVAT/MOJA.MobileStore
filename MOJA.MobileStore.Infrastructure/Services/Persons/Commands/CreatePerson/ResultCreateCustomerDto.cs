using MOJA.MobileStore.Common.Dtos;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Commands.CreatePerson
{
    public class ResultCreateCustomerDto : BaseResultDto
    {
        public ResultCreateCustomerDto(bool isSuccessed, string message) : base(isSuccessed, message)
        {
        }
    }
}
