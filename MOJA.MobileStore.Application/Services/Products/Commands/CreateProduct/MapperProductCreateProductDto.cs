using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Entities.Products;
using MOJA.MobileStore.Domain.Entities.Products.Features;

namespace MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct
{
    public class MapperProductCreateProductDto
    {
        public static Product To(CreateProductDto dto)
        {
            return new Product
            {
                BackGuardId = dto.BackGuardId,
                BatterySpecifications = dto.BatterySpecifications,
                Bluetooth = dto.Bluetooth,
                BluetoothVersion = dto.BluetoothVersion,
                BodyStructure = dto.BodyStructure,
                BrandId = dto.BrandId,
                CameraCapabilitiesDescriptions = dto.CameraCapabilitiesDescriptions,
                Chip = dto.Chip,
                CommunicationNetworks = dto.CommunicationNetworks
                    .Select(cn => new CommunicationNetwork { Id = cn })
                    .ToList(),
                CommunicationPorts = dto.CommunicationPorts,
                CommunicationTechnologies = dto.CommunicationTechs
                    .Select(ct => new CommunicationTechnology { Id = ct })
                    .ToList(),
                CPU = dto.CPU,
                CPUFrequency = dto.CPUFrequency,
                FilmingDescriptions = dto.FilmingDescriptions,
                Flash = dto.Flash,
                FrontCameraDescriptions = dto.FrontCameraDescriptions,
                GPU = dto.GPU,
                Height = dto.Height,
                InternalStorageId = dto.InternalStorageId,
                IntrodutionDate = dto.IntrodutionDate,
                Is64Bit = dto.Is64Bit,
                Length = dto.Length,
                MemoryCardSupportId = dto.MemoryCardSupportId,
                MobileCategoryId = dto.MobileCategoryId,
                MobileColors = dto.Colors
                    .Select(mc => new MobileColor { Id = mc })
                    .ToList(),
                MobileTechnologies = dto.MobileTechs
                    .Select(mt => new MobileTechnology { Id = mt })
                    .ToList(),
                Model = dto.Model,
                OSId = dto.OSId,
                OtherFeatures = dto.OtherFeatures,
                PhotoResolutionId = dto.PhotoResolutionId,
                ProductIntroduction = dto.Introduction,
                RAMId = dto.RAMId,
                RearCameraId = dto.RearCameraId,
                ScreenPixelsPerInch = dto.ScreenPixelsPerInch,
                ScreenResolutionHeight = dto.ScreenResolutionHeight,
                ScreenResolutionLenght = dto.ScreenResolutionLenght,
                ScreenTechnologyId = dto.ScreenTechId,
                Sensors = dto.Sensors
                    .Select(s => new MobileSensor { Id = s })
                    .ToList(),
                SizeId = dto.SizeId,
                SIMDescId = dto.SIMDescId,
                SIMCardNumber = dto.SIMCardNumber,
                SpecialFeatures = dto.SpecialFeatures
                    .Select(sp => new SpecialFeature { Id = sp })
                    .ToList(),
                Weight=dto.Weight,
                Width=dto.Width,
                Wifi=dto.Wifi,
                Images=dto.Images
                    .Select(i=>new ProductImage { PhotoPath=i.PhotoPath})
                    .ToList(),
                    
            };
        }
    }
}
