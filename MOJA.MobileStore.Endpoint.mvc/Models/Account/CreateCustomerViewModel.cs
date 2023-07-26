using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MOJA.MobileStore.Endpoint.mvc.Models.Account
{
    public class CreateCustomerViewModel
    {
        [Display(Name="نام")]
        [Required(ErrorMessage = "نام نباید خالی باشد")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "نام خانوادگی نباید خالی باشد")]
        public string Family { get; set; } = string.Empty;
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage ="ایمیل نباید خالی باشد")]
        [EmailAddress(ErrorMessage ="ایمیل معتبر وارد کنید")]
        public string Email { get; set; } = string.Empty;
        [Display(Name="پسوورد")]
        [Required(ErrorMessage ="پسوورد را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Display(Name = "تکرار پسوورد")]
        [Required(ErrorMessage = "تکرار پسوورد را وارد کنید")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="تکرار پسوورد با پسوورد یکی نیستند")]
        public string RePassword { get; set; } = string.Empty;
    }
}
