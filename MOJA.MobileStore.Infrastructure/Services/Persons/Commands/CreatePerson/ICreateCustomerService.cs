namespace MOJA.MobileStore.Infrastructure.Services.Persons.Commands.CreatePerson
{
    public interface ICreateCustomerService
    {
        Task<ResultCreateCustomerDto> ExecuteAsync(CreateCustomerDto dto);
    }
}
