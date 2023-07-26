using MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson;

namespace MOJA.MobileStore.Endpoint.mvc.Models.Account
{
    public class SignInCustomerVMMapper
    {
        public RequestSignInPersonDto To(SignInCustomerViewModel vm)
            => new RequestSignInPersonDto
            {
                Email = vm.Email,
                Password = vm.Password,
                IsPersistence = vm.IsPersistence,
            };
    }
}
