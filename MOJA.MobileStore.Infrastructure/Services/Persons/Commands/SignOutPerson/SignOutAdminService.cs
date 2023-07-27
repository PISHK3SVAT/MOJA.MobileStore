using Microsoft.AspNetCore.Identity;

using MOJA.MobileStore.Domain.Entities.Users.Admins;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Commands.SignOutPerson
{
    public class SignOutAdminService : ISignOutPersonService
    {
        private SignInManager<Admin> _signInManager;

        public SignOutAdminService(SignInManager<Admin> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task ExecuteAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
