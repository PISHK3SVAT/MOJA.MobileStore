using MOJA.MobileStore.Common.Dtos;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson
{
    public class ResultSignInPersonDto : BaseResultDto
    {
        public ResultSignInPersonDto(bool isSuccessed, string message) : base(isSuccessed, message)
        {
        }
    }
}
