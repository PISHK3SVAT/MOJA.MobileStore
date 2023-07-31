using System.ComponentModel.DataAnnotations;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Models.Product
{
    public class ShowProductTableViewModel
    {
        public long Id { get; set; }
        
        [Display(Name ="مدل")]
        public string Model { get; set; }=string.Empty;

        [Display(Name = "فناوری صفحه‌نمایش")]
        public string ScreenTech { get; set; } = string.Empty;

        [Display(Name = "اندازه")]
        public string Size { get; set; } = string.Empty;

        [Display(Name = "حافظه داخلی")]
        public string InternalStorage { get; set; } = string.Empty;

        [Display(Name = "مقدار RAM")]
        public string Ram { get; set; } = string.Empty;
    }
}
