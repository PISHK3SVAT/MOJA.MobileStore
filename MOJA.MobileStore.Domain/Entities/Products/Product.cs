using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Products.Features;

namespace MOJA.MobileStore.Domain.Entities.Products
{
    public class Product : BaseEntity<long>
    {
        public int SalesPrice { get; set; }
        public List<MobileColor> MobileColors { get; set; } = new List<MobileColor>();
        public string ProductIntroduction { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public MobileBrand Brand { get; set; } = new MobileBrand();

        #region Dimention
        public float Length { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        #endregion

        public float Weight { get; set; }

        #region Screen
        public int ScreenTechnologyId { get; set; }
        public ScreenTechnology ScreenTechnology { get; set; } = new ScreenTechnology();
        public int SizeId { get; set; }
        public MobileSize Size { get; set; } = new();
        //public int ScreenSizeRangeId { get; set; }
        //public MobileSize ScreenSizeRange { get; set; } = new MobileSize();
        public short ScreenResolutionHeight { get; set; }
        public short ScreenResolutionLenght { get; set; }
        public short ScreenPixelsPerInch { get; set; }
        #endregion

        #region SIMCard
        public int SIMDescId { get; set; }
        public SIMDesc SIMDesc { get; set; } = new SIMDesc();
        public short SIMCardNumber { get; set; }
        #endregion

        public string BodyStructure { get; set; } = string.Empty;
        public List<SpecialFeature> SpecialFeatures { get; set; } = new();
        public DateOnly IntrodutionDate { get; set; }
        public int BackGuardId { get; set; }
        public BackGuardMaterial BackGuard { get; set; } = new BackGuardMaterial();
        public string Model { get; set; } = string.Empty;
        public Guid StoreProductID { get; set; } = Guid.NewGuid();
        public string? OtherFeatures { get; set; }
        public string Chip { get; set; } = string.Empty;
        public string CPU { get; set; } = string.Empty;
        public string CPUFrequency { get; set; } = string.Empty;
        public bool Is64Bit { get; set; }
        public string GPU { get; set; } = string.Empty;
        public List<CommunicationNetwork> CommunicationNetworks { get; set; } = new();
        public int InternalStorageId { get; set; }
        public InternalStorage InternalStorage { get; set; } = new();
        public int RAMId { get; set; }
        public MobileRam RAM { get; set; } = new MobileRam();
        public int MemoryCardSupportId { get; set; }
        public MemoryCardSupport MemoryCardSupport { get; set; } = new();
        public int MobileCategoryId { get; set; }
        public MobileCategory MobileCategory { get; set; } = new();
        public List<CommunicationTechnology> CommunicationTechnologies { get; set; } = new();
        public string Wifi { get; set; } = string.Empty;
        public string Bluetooth { get; set; } = string.Empty;
        public float BluetoothVersion { get; set; }
        public List<MobileTechnology> MobileTechnologies { get; set; } = new();
        public string CommunicationPorts { get; set; } = string.Empty;
        public int RearCameraId { get; set; }
        public RearCamera RearCamera { get; set; } = new();
        public int PhotoResolutionId { get; set; }
        public PhotoResolution PhotoResolution { get; set; } = new();
        public string Flash { get; set; } = string.Empty;
        public string CameraCapabilitiesDescriptions { get; set; } = string.Empty;
        public string FilmingDescriptions { get; set; } = string.Empty;
        public string FrontCameraDescriptions { get; set; } = string.Empty;
        public int OSId { get; set; }
        public MobileOS OS { get; set; } = new();
        public List<MobileSensor> Sensors { get; set; } = new();
        public string BatterySpecifications { get; set; } = string.Empty;
        public List<ProductImage> Images { get; set; } = new();

        public List<Comment>? Comments { get; set; }
        public List<Question>? Questions { get; set; }
        //public List<ProductInstance>? ProductInstances { get; set; }
    }
}
