using MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Models.Account
{
    public class SignInAdminVMMapper
    {
        public RequestSignInPersonDto To(SignInAdminViewModel vm)
            => new RequestSignInPersonDto
            {
                Email = vm.Email,
                Password = vm.Password,
                IsPersistence = vm.IsPersistence,
            };
    }
}
