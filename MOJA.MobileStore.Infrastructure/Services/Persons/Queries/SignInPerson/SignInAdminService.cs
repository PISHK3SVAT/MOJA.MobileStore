using Microsoft.AspNetCore.Identity;

using MOJA.MobileStore.Domain.Entities.Users.Admins;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson
{
    public class SignInAdminService : ISignInPersonService
    {
        private UserManager<Admin> _userManager;
        private SignInManager<Admin> _signInManager;

        public SignInAdminService(SignInManager<Admin> signInManager, UserManager<Admin> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<ResultSignInPersonDto> ExecuteAsync(RequestSignInPersonDto dto)
        {
            var person = await _userManager.FindByNameAsync(dto.Email);
            if (person == null)
            {
                return new ResultSignInPersonDto(false, "کاربر یافت نشد");
            }
            await _signInManager.SignOutAsync();
            var result = await _signInManager
                .PasswordSignInAsync(person, dto.Password, dto.IsPersistence, true);
            if (result.Succeeded)
            {
                return new ResultSignInPersonDto(true, "شما با موفقیت وارد شدید");
            }
            if (result.IsLockedOut)
            {
                return new ResultSignInPersonDto(
                    false,
                    "به دلیل درخواست اشتباه بیش از حد بلاک شده اید، بعدا تلاش کنید"
                    );
            }
            if (result.IsNotAllowed)
            {
                return new ResultSignInPersonDto(false, "شما مجاز به ورود نیستید");
            }
            if (result.RequiresTwoFactor)
            {
                //implement later
            }
            return new ResultSignInPersonDto(false, "پسوورد اشتباه است");
        }
    }
}
