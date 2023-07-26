using Microsoft.AspNetCore.Identity;

using MOJA.MobileStore.Domain.Entities.Users;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson
{
    public class SignInPersonService : ISignInPersonService
    {
        private UserManager<Person> _userManager;
        private SignInManager<Person> _signInManager;

        public SignInPersonService(SignInManager<Person> signInManager, UserManager<Person> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<ResultSignInPersonDto> ExecuteAsync(RequestSignInPersonDto dto)
        {
            var person =await _userManager.FindByNameAsync(dto.Email);
            if (person == null)
            {
                return new ResultSignInPersonDto(false, "کاربر یافت نشد");
            }
            await _signInManager.SignOutAsync();
            var result =await _signInManager
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
