namespace MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson
{
    public class RequestSignInPersonDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsPersistence { get; set; }
    }
}
