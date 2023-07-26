using System.ComponentModel.DataAnnotations;

namespace MOJA.MobileStore.Endpoint.mvc.Models.Account
{
    public class SignInCustomerViewModel
    {
        public string ReturnUrl { get; set; } = string.Empty;
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "ایمیل نباید خالی باشد")]
        [EmailAddress(ErrorMessage = "ایمیل معتبر وارد کنید")]
        public string Email { get; set; }=string.Empty;
        [Display(Name = "پسوورد")]
        [Required(ErrorMessage = "پسوورد را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }=string.Empty;
        [Display(Name = "مرا به خاطر داشته باش")]
        public bool IsPersistence { get; set; }
    }
}
