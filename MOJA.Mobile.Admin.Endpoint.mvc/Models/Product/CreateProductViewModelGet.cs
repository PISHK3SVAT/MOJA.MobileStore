using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc.Rendering;

using MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct.Features;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Models.Product
{
    public class CreateProductViewModelGet
    {
        public CreateProductViewModelGet(SelectList colors, SelectList brands, SelectList sizes,
            SelectList sIMDescs, SelectList speacialFeatures, SelectList backGuards,
            SelectList communicationNetworks, SelectList rAMs, SelectList mobileCategorys,
            SelectList screenTechs, SelectList communicationTechs, SelectList mobileTechs,
            SelectList oSs, SelectList sensors, SelectList memoryCardSupports,
            SelectList rearCameras, SelectList photoResolutions, SelectList internalStorages)
        {
            Colors = colors;
            Brands = brands;
            Sizes = sizes;
            SIMDescs = sIMDescs;
            SpeacialFeatures = speacialFeatures;
            BackGuards = backGuards;
            CommunicationNetworks = communicationNetworks;
            RAMs = rAMs;
            MobileCategories = mobileCategorys;
            ScreenTechs = screenTechs;
            CommunicationTechs = communicationTechs;
            MobileTechs = mobileTechs;
            OSs = oSs;
            Sensors = sensors;
            MemoryCardSupports = memoryCardSupports;
            RearCameras = rearCameras;
            PhotoResolutions = photoResolutions;
            InternalStorages = internalStorages;
        }

        [Display(Name = "قیمت فروش")]
        [Required(ErrorMessage = "قیمت نباید خالی باشد")]
        public int? SalesPrice { get; set; }

        [Display(Name = "رنگ")]
        [Required(ErrorMessage = "رنگ نباید خالی باشد")]
        public List<int> SelectedColors { get; set; } = new();
        public SelectList Colors { get; set; }
        
        [Display(Name = "معرفی")]
        [Required(ErrorMessage = "معرفی نباید خالی باشد")]
        public string Introduction { get; set; } = string.Empty;

        [Display(Name = "برند")]
        [Required(ErrorMessage = "برند نباید خالی باشد")]
        public int SelectedBrand { get; set; }
        public SelectList Brands { get; set; }

        #region Dimention
        [Display(Name = "طول")]
        [Required(ErrorMessage = "طول نباید خالی باشد")]
        public float? Length { get; set; }
        
        [Display(Name = "ارتفاع")]
        [Required(ErrorMessage = "ارتفاع نباید خالی باشد")]
        public float? Height { get; set; }
        
        [Display(Name = "عرض")]
        [Required(ErrorMessage = "عرض نباید خالی باشد")]
        public float? Width { get; set; }
        #endregion
        
        [Display(Name = "وزن")]
        [Required(ErrorMessage = "وزن نباید خالی باشد")]
        public float? Weight { get; set; }

        #region Screen
        [Display(Name = "تکنولوژی صفحه")]
        [Required(ErrorMessage = "تکنولوژی صفحه نباید خالی باشد")]
        public int SelectedScreenTech { get; set; }
        public SelectList ScreenTechs { get; set; }

        [Display(Name = "اندازه")]
        [Required(ErrorMessage = "اندازه نباید خالی باشد")]
        public int SelectedSize { get; set; }
        public SelectList Sizes { get; set; }
        
        [Display(Name = "ارتفاع رزلوشن")]
        [Required(ErrorMessage = "ارتفاع رزلوشن نباید خالی باشد")]
        public short? ScreenResolutionHeight { get; set; }
        
        [Display(Name = "طول رزلوشن")]
        [Required(ErrorMessage = "طول رزلوشن نباید خالی باشد")]
        public short? ScreenResolutionLenght { get; set; }
        
        [Display(Name = "تراکم پیکسلی")]
        [Required(ErrorMessage = "تراکم پیکسلی نباید خالی باشد")]
        public short? ScreenPixelsPerInch { get; set; }
        #endregion

        #region SIMCard
        [Display(Name = "توضیحات سیمکارت")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedSIMDesc { get; set; }
        public SelectList SIMDescs { get; set; }
        
        [Display(Name = "تعداد سیمکارت")]
        [Required(ErrorMessage = "تعداد سیمکارت نباید خالی باشد")]
        public short? SIMCardNumber { get; set; }
        #endregion

        [Display(Name = "ساختار بدنه")]
        [Required(ErrorMessage = "ساختار بدنه نباید خالی باشد")]
        public string BodyStructure { get; set; } = string.Empty;

        [Display(Name = "ویژگی های خاص")]
        [Required(ErrorMessage = "ویژگی های خاص نباید خالی باشد")]
        public List<int> SelectedSpecialFeatures { get; set; } = new();
        public SelectList SpeacialFeatures { get; set; }

        [Display(Name = "تاریخ معرفی")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "تاریخ معرفی نباید خالی باشد")]
        public DateOnly IntrodutionDate { get; set; }

        [Display(Name = "محافظت")]
        [Required(ErrorMessage = "محافظت نباید خالی باشد")]
        public int SelectedBackGuard { get; set; }
        public SelectList BackGuards { get; set; }

        [Display(Name = "مدل")]
        [Required(ErrorMessage = "مدل نباید خالی باشد")]
        public string Model { get; set; } = string.Empty;

        [Display(Name = "سایر قابلیت ها")]
        public string? OtherFeatures { get; set; }

        [Display(Name = "تراشه")]
        [Required(ErrorMessage = "تراشه نباید خالی باشد")]
        public string Chip { get; set; } = string.Empty;

        [Display(Name = "پردازنده مرکزی")]
        [Required(ErrorMessage = "پردازنده مرکزی نباید خالی باشد")]
        public string CPU { get; set; } = string.Empty;

        [Display(Name = "فرکانس پردازنده مرکزی")]
        [Required(ErrorMessage = "فرکانس پردازنده مرکزی نباید خالی باشد")]
        public string CPUFrequency { get; set; } = string.Empty;

        [Display(Name = "پردازنده 64 بیتی؟")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public bool Is64Bit { get; set; }

        [Display(Name = "پردازنده گرافیکی")]
        [Required(ErrorMessage = "پردازنده گرافیکی نباید خالی باشد")]
        public string GPU { get; set; } = string.Empty;

        [Display(Name = "شبکه های ارتباطی")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public List<int> SelectedCommunicationNetworks { get; set; } = new();
        public SelectList CommunicationNetworks { get; set; }

        [Display(Name = "حافظه داخلی")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedInternalStorage { get; set; }
        public SelectList InternalStorages { get; set; }

        [Display(Name = "رم")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedRAM { get; set; }
        public SelectList RAMs { get; set; }

        [Display(Name = "پشتیبانی از کارت حافظه")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedMemoryCardSupport { get; set; }
        public SelectList MemoryCardSupports { get; set; }

        [Display(Name = "دسته بندی")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedMobileCategory { get; set; }
        public SelectList MobileCategories { get; set; }

        [Display(Name = "فناوری های ارتباطی")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public List<int> SelectedCommunicationTechs { get; set; } = new();
        public SelectList CommunicationTechs { get; set; }

        [Display(Name = "وای فای")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string Wifi { get; set; } = string.Empty;

        [Display(Name = "بلوتوث")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string Bluetooth { get; set; } = string.Empty;

        [Display(Name = "نسخه بلوتوث")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public float? BluetoothVersion { get; set; }

        [Display(Name = "فناوری موبایل")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public List<int> SelectedMobileTechs { get; set; } = new();
        public SelectList MobileTechs { get; set; }

        [Display(Name = "درگاه های ارتباطی")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string CommunicationPorts { get; set; } = string.Empty;

        [Display(Name = "دوربین پشت")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedRearCamera { get; set; }
        public SelectList RearCameras { get; set; }


        [Display(Name = "رزلوشن عکس")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedPhotoResolution { get; set; }
        public SelectList PhotoResolutions { get; set; }


        [Display(Name = "فلش")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string Flash { get; set; } = string.Empty;

        [Display(Name = "قابلیت های دوربین")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string CameraCapabilitiesDescriptions { get; set; } = string.Empty;

        [Display(Name = "قابلیت های فیلمبرداری")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string FilmingDescriptions { get; set; } = string.Empty;

        [Display(Name = "قابلیت های دوربین سلفی")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string FrontCameraDescriptions { get; set; } = string.Empty;


        [Display(Name = "سیستم عامل")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public int SelectedOS { get; set; }
        public SelectList OSs { get; set; }


        [Display(Name = "حسگرها")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public List<int> SelectedSensors { get; set; } = new();
        public SelectList Sensors { get; set; }


        [Display(Name = "مشخصات باتری")]
        [Required(ErrorMessage = "این فیلد نباید خالی باشد")]
        public string BatterySpecifications { get; set; } = string.Empty;


        [Display(Name = "عکس های محصول")]
        [Required(ErrorMessage = "عکس های محصول را آپلود کنید")]
        public List<IFormFile> Images { get; set; } = new();
    }
}
