using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson
{
    public interface ISignInPersonService
    {
        Task<ResultSignInPersonDto> ExecuteAsync(RequestSignInPersonDto dto);
    }
}
