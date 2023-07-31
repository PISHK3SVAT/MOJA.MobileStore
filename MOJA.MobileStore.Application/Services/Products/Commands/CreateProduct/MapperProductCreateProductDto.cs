using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Domain.Entities.Products;
using MOJA.MobileStore.Domain.Entities.Products.Features;

namespace MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct
{
    public class MapperProductCreateProductDto
    {
        public static Product To(CreateProductDto dto,IAppDbContext db)
        {

            var product = new Product
            {
                BackGuard = db.BackGuards.Find(dto.BackGuardId)!,
                BatterySpecifications = dto.BatterySpecifications,
                Bluetooth = dto.Bluetooth,
                BluetoothVersion = dto.BluetoothVersion,
                BodyStructure = dto.BodyStructure,
                Brand = db.MobileBrands.Find(dto.BrandId)!,
                CameraCapabilitiesDescriptions = dto.CameraCapabilitiesDescriptions,
                Chip = dto.Chip,
                CommunicationNetworks = dto.CommunicationNetworks
                    .Select(cn => db.CommunicationNetworks.Find(cn)!)
                    .ToList(),
                CommunicationPorts = dto.CommunicationPorts,
                CommunicationTechnologies = dto.CommunicationTechs
                    .Select(ct =>  db.CommunicationTechnologies.Find(ct)!)
                    .ToList(),
                CPU = dto.CPU,
                CPUFrequency = dto.CPUFrequency,
                FilmingDescriptions = dto.FilmingDescriptions,
                Flash = dto.Flash,
                FrontCameraDescriptions = dto.FrontCameraDescriptions,
                GPU = dto.GPU,
                Height = dto.Height,
                InternalStorage = db.InternalStorages.Find(dto.InternalStorageId)!,
                IntrodutionDate = dto.IntrodutionDate,
                Is64Bit = dto.Is64Bit,
                Length = dto.Length,
                MemoryCardSupport = db.MemoryCardSupports.Find(dto.MemoryCardSupportId)!,
                MobileCategory = db.MobileCategories.Find(dto.MobileCategoryId)!,
                MobileColors = dto.Colors
                    .Select(mc => db.Colors.Find(mc)!)
                    .ToList(),
                MobileTechnologies = dto.MobileTechs
                    .Select(mt => db.MobileTechnologies.Find(mt)!)
                    .ToList(),
                Model = dto.Model,
                OS = db.MobileOSs.Find(dto.OSId)!,
                OtherFeatures = dto.OtherFeatures,
                PhotoResolution = db.PhotoResolutions.Find(dto.PhotoResolutionId)!,
                ProductIntroduction = dto.Introduction,
                RAM = db.MobileRams.Find(dto.RAMId)!,
                RearCamera = db.RearCameras.Find(dto.RearCameraId)!,
                ScreenPixelsPerInch = dto.ScreenPixelsPerInch,
                ScreenResolutionHeight = dto.ScreenResolutionHeight,
                ScreenResolutionLenght = dto.ScreenResolutionLenght,
                ScreenTechnology = db.ScreenTechnologies.Find(dto.ScreenTechId)!,
                Sensors = dto.Sensors
                    .Select(s => db.MobileSensors.Find(s)!)
                    .ToList(),
                Size = db.MobileSizes.Find(dto.SizeId)!,
                SIMDesc = db.SIMDescs.Find(dto.SIMDescId)!,
                SIMCardNumber = dto.SIMCardNumber,
                SpecialFeatures = dto.SpecialFeatures
                    .Select(sp =>db.SpecialFeatures.Find(sp)!)
                    .ToList(),
                Weight=dto.Weight,
                Width=dto.Width,
                Wifi=dto.Wifi,
                //Images=dto.Images
                //    .Select(i=>new ProductImage { PhotoPath=i.PhotoPath})
                //    .ToList(),
                    
            };
            return product;
        }
    }
}
