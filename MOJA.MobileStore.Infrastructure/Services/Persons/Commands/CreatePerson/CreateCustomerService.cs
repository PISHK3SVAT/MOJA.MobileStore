using Microsoft.AspNetCore.Identity;

using MOJA.MobileStore.Domain.Entities.Users;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Commands.CreatePerson
{
    public class CreateCustomerService : ICreateCustomerService
    {
        private UserManager<Person> _userManager;

        public CreateCustomerService(UserManager<Person> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ResultCreateCustomerDto> ExecuteAsync(CreateCustomerDto dto)
        {
            var person = new MapperCustomerCreateCustomerDto().ToPerson(dto);
            var result = await _userManager.CreateAsync(person, dto.Password);
            if (!result.Succeeded)
            {
                var totalErrors = result.Errors.Select(e => e.Description)
                    .Aggregate((a, b) => a + Environment.NewLine + b);
                return new ResultCreateCustomerDto(false, totalErrors);
            }
            return new ResultCreateCustomerDto(true, "کاربر با موفقیت ساخته شد");
        }
    }
}
