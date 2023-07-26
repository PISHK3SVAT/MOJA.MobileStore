using MOJA.MobileStore.Domain.Entities.Users;
using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Infrastructure.Services.Persons.Commands.CreatePerson
{
    internal class MapperCustomerCreateCustomerDto
    {
        public Customer ToPerson(CreateCustomerDto dto)
        {
            return new Customer
            {
                Name = dto.Name,
                Family = dto.Family,
                Email = dto.Email,
                UserName = dto.Email,
            };
        }
    }
}
