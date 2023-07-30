using MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Models.Product
{
    public class MapperCreateProductDtoViewModel
    {
        public static CreateProductDto To(CreateProductViewModelPost vm)
        {
            return new CreateProductDto
            {
                BackGuardId = vm.SelectedBackGuard,
                BatterySpecifications = vm.BatterySpecifications,
                Bluetooth = vm.Bluetooth,
                BluetoothVersion= vm.BluetoothVersion,
                BodyStructure= vm.BodyStructure,
                BrandId=vm.SelectedBrand,
                CameraCapabilitiesDescriptions=vm.CameraCapabilitiesDescriptions,
                Chip=vm.Chip,
                Colors=vm.SelectedColors,
                CommunicationNetworks=vm.SelectedCommunicationNetworks,
                CommunicationPorts=vm.CommunicationPorts,
                CommunicationTechs=vm.SelectedCommunicationTechs,
                CPU=vm.CPU,
                CPUFrequency=vm.CPUFrequency,
                FilmingDescriptions=vm.FilmingDescriptions,
                Flash=vm.Flash,
                FrontCameraDescriptions=vm.FrontCameraDescriptions,
                GPU=vm.GPU,
                Height=vm.Height,
                InternalStorageId=vm.SelectedInternalStorage,
                Introduction = vm.Introduction,
                IntrodutionDate = vm.IntrodutionDate,
                Is64Bit=vm.Is64Bit,
                Length= vm.Length,
                MemoryCardSupportId=vm.SelectedMemoryCardSupport,
                MobileCategoryId=vm.SelectedMobileCategory,
                MobileTechs=vm.SelectedMobileTechs,
                Model=vm.Model,
                OSId=vm.SelectedOS,
                OtherFeatures=vm.OtherFeatures,
                PhotoResolutionId=vm.SelectedPhotoResolution,
                RAMId=vm.SelectedRAM,
                RearCameraId=vm.SelectedRAM,
                ScreenPixelsPerInch = vm.ScreenPixelsPerInch,
                ScreenResolutionHeight=vm.ScreenResolutionHeight,
                ScreenResolutionLenght = vm.ScreenResolutionLenght,
                ScreenTechId = vm.SelectedScreenTech,
                Sensors=vm.SelectedSensors,
                SIMCardNumber= vm.SIMCardNumber,
                SIMDescId=vm.SelectedSIMDesc,
                SizeId=vm.SelectedSize,
                SpecialFeatures=vm.SelectedSpecialFeatures,
                Weight=vm.Weight,
                Width=vm.Width,
                Wifi=vm.Wifi,
            };
        }
    }
}
