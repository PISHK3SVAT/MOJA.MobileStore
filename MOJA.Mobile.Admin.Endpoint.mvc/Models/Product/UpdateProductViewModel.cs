using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Models.Product
{
    public class UpdateProductViewModel
    {
        public long Id { get; set; }
        
        [Display(Name = "رزلوشن عکس")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedPhotoResolution { get; set; }
        public required SelectList PhotoResolutions { get; set; }

        [Display(Name = "اندازه")]
        [Required(ErrorMessage = "اندازه نباید خالی باشد")]
        public int SelectedSize { get; set; }
        public required SelectList Sizes { get; set; }

        [Display(Name = "طول")]
        [Required(ErrorMessage = "طول نباید خالی باشد")]
        public float Length { get; set; }

        [Display(Name = "ارتفاع")]
        [Required(ErrorMessage = "ارتفاع نباید خالی باشد")]
        public float Height { get; set; }

        [Display(Name = "عرض")]
        [Required(ErrorMessage = "عرض نباید خالی باشد")]
        public float Width { get; set; }
    }
}
