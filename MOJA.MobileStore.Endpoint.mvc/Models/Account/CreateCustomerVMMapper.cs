using MOJA.MobileStore.Infrastructure.Services.Persons.Commands.CreatePerson;

namespace MOJA.MobileStore.Endpoint.mvc.Models.Account
{
    public class CreateCustomerVMMapper
    {
        public CreateCustomerDto To(CreateCustomerViewModel dto)
        {
            return new CreateCustomerDto
            {
                Name = dto.Name,
                Family = dto.Family,
                Email = dto.Email,
                Password = dto.Password,
            };
        }
        public CreateCustomerViewModel To(CreateCustomerDto vm)
        {
            return new CreateCustomerViewModel
            {
                Name = vm.Name,
                Family = vm.Family,
                Email = vm.Email,
                Password = vm.Password,
            };
        }
    }
}
