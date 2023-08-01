namespace MOJA.Mobile.Admin.Endpoint.mvc.Models.Product
{
    public class CreateProductViewModelPost
    {
        public int SalesPrice { get; set; }
        public List<int> SelectedColors { get; set; } = new();
        public string Introduction { get; set; } = string.Empty;
        public int SelectedBrand { get; set; }

        #region Dimention
        public float Length { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        #endregion

        public float Weight { get; set; }

        #region Screen
        public int SelectedScreenTech { get; set; }
        public int SelectedSize { get; set; }
        public short ScreenResolutionHeight { get; set; }
        public short ScreenResolutionLenght { get; set; }
        public short ScreenPixelsPerInch { get; set; }
        #endregion

        #region SIMCard
        public int SelectedSIMDesc { get; set; }
        public short SIMCardNumber { get; set; }
        #endregion
        public string BodyStructure { get; set; } = string.Empty;
        public List<int> SelectedSpecialFeatures { get; set; } = new();
        public DateOnly IntrodutionDate { get; set; }
        public int SelectedBackGuard { get; set; }
        public string Model { get; set; } = string.Empty;
        public string? OtherFeatures { get; set; }
        public string Chip { get; set; } = string.Empty;
        public string CPU { get; set; } = string.Empty;
        public string CPUFrequency { get; set; } = string.Empty;
        public bool Is64Bit { get; set; }
        public string GPU { get; set; } = string.Empty;
        public List<int> SelectedCommunicationNetworks { get; set; } = new();
        public int SelectedInternalStorage { get; set; }
        public int SelectedRAM { get; set; }
        public int SelectedMemoryCardSupport { get; set; }
        public int SelectedMobileCategory { get; set; }
        public List<int> SelectedCommunicationTechs { get; set; } = new();
        public string Wifi { get; set; } = string.Empty;
        public string Bluetooth { get; set; } = string.Empty;
        public float BluetoothVersion { get; set; }
        public List<int> SelectedMobileTechs { get; set; } = new();
        public string CommunicationPorts { get; set; } = string.Empty;
        public int SelectedRearCamera { get; set; }
        public int SelectedPhotoResolution { get; set; }
        public string Flash { get; set; } = string.Empty;
        public string CameraCapabilitiesDescriptions { get; set; } = string.Empty;
        public string FilmingDescriptions { get; set; } = string.Empty;
        public string FrontCameraDescriptions { get; set; } = string.Empty;
        public int SelectedOS { get; set; }
        public List<int> SelectedSensors { get; set; } = new();
        public string BatterySpecifications { get; set; } = string.Empty;
        public List<IFormFile> Images { get; set; } = new();
    }
}
