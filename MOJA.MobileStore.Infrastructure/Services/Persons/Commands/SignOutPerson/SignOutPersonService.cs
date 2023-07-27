using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

using MOJA.MobileStore.Domain.Entities.Users;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Commands.SignOutPerson
{

    public class SignOutPersonService : ISignOutPersonService
    {
        private SignInManager<Person> _signInManager;

        public SignOutPersonService(SignInManager<Person> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task ExecuteAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
