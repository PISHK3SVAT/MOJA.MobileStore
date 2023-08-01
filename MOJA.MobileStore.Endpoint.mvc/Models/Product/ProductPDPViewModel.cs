using MOJA.MobileStore.Domain.Entities.Products.Features;
using MOJA.MobileStore.Domain.Entities.Products;

namespace MOJA.MobileStore.Endpoint.mvc.Models.Product
{
    public class ProductPDPViewModel
    {
        public int Price { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<string> MobileColors { get; set; } = new();
        public string ProductIntroduction { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Dimention { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string ScreenTechnology { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string ScreenResolution { get; set; } = string.Empty;
        public string ScreenPixelsPerInch { get; set; } = string.Empty;
        public string SIMDesc { get; set; } = string.Empty;
        public short SIMCardNumber { get; set; }
        public string BodyStructure { get; set; } = string.Empty;
        public List<string> SpecialFeatures { get; set; } = new();
        public DateOnly IntrodutionDate { get; set; }
        public string BackGuard { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string StoreProductID { get; set; } = string.Empty;
        public string? OtherFeatures { get; set; }
        public string Chip { get; set; } = string.Empty;
        public string CPU { get; set; } = string.Empty;
        public string CPUFrequency { get; set; } = string.Empty;
        public string Is64Bit { get; set; } = string.Empty;
        public string GPU { get; set; } = string.Empty;
        public List<string> CommunicationNetworks { get; set; } = new();
        public string InternalStorage { get; set; } = string.Empty;
        public string RAM { get; set; } = string.Empty;
        public string MemoryCardSupport { get; set; } = string.Empty;
        public string MobileCategory { get; set; } = string.Empty;
        public List<string> CommunicationTechnologies { get; set; } = new();
        public string Wifi { get; set; } = string.Empty;
        public string Bluetooth { get; set; } = string.Empty;
        public float BluetoothVersion { get; set; }
        public List<string> MobileTechnologies { get; set; } = new();
        public string CommunicationPorts { get; set; } = string.Empty;
        public string RearCamera { get; set; } = string.Empty;
        public string PhotoResolution { get; set; } = string.Empty;
        public string Flash { get; set; } = string.Empty;
        public string CameraCapabilitiesDescriptions { get; set; } = string.Empty;
        public string FilmingDescriptions { get; set; } = string.Empty;
        public string FrontCameraDescriptions { get; set; } = string.Empty;
        public string OS { get; set; } = string.Empty;
        public List<string> Sensors { get; set; } = new();
        public string BatterySpecifications { get; set; } = string.Empty;
        public List<string> Images { get; set; } = new();
    }
}
