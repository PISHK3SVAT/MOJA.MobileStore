﻿namespace MOJA.MobileStore.Infrastructure.Services.Persons.Commands.CreatePerson
{
    public class CreateCustomerDto
    {
        public string Name { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
