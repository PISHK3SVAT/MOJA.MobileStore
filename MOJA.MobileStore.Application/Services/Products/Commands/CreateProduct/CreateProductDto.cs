using Microsoft.AspNetCore.Http;

using MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct.Features;

namespace MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct
{
    public class CreateProductDto
    {
        public List<int> Colors { get; set; } = new();
        public string Introduction { get; set; } = string.Empty;
        public int BrandId { get; set; }
        #region Dimention
        public float Length { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        #endregion
        public float Weight { get; set; }
        #region Screen
        public int ScreenTechId { get; set; }
        public int SizeId { get; set; }
        public short ScreenResolutionHeight { get; set; }
        public short ScreenResolutionLenght { get; set; }
        public short ScreenPixelsPerInch { get; set; }
        #endregion
        #region SIMCard
        public int SIMDescId { get; set; }
        public short SIMCardNumber { get; set; }
        #endregion
        public string BodyStructure { get; set; } = string.Empty;
        public List<int> SpecialFeatures { get; set; } = new();
        public DateOnly IntrodutionDate { get; set; }
        public int BackGuardId { get; set; } = new();
        public string Model { get; set; } = string.Empty;
        public string? OtherFeatures { get; set; }
        public string Chip { get; set; } = string.Empty;
        public string CPU { get; set; } = string.Empty;
        public string CPUFrequency { get; set; } = string.Empty;
        public bool Is64Bit { get; set; }
        public string GPU { get; set; } = string.Empty;
        public List<int> CommunicationNetworks { get; set; } = new();
        public int InternalStorageId { get; set; }
        public int RAMId { get; set; }
        public int MemoryCardSupportId { get; set; }
        public int MobileCategoryId { get; set; }
        public List<int> CommunicationTechs { get; set; } = new();
        public string Wifi { get; set; } = string.Empty;
        public string Bluetooth { get; set; } = string.Empty;
        public float BluetoothVersion { get; set; }
        public List<int> MobileTechs { get; set; } = new();
        public string CommunicationPorts { get; set; } = string.Empty;
        public int RearCameraId { get; set; }
        public int PhotoResolutionId { get; set; }
        public string Flash { get; set; } = string.Empty;
        public string CameraCapabilitiesDescriptions { get; set; } = string.Empty;
        public string FilmingDescriptions { get; set; } = string.Empty;
        public string FrontCameraDescriptions { get; set; } = string.Empty;
        public int OSId { get; set; }
        public List<int> Sensors { get; set; } = new();
        public string BatterySpecifications { get; set; } = string.Empty;
        public List<IFormFile> Images { get; set; } = new();
    }
}
