using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Application.Services.Products.UriComposer;
using MOJA.MobileStore.Endpoint.mvc.Models.Product;

namespace MOJA.MobileStore.Endpoint.mvc.Controllers
{
    public class ProductController : Controller
    {
        private IAppDbContext db;

        public ProductController(IAppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = db.Products
                .Select(p => new ProductPLPViewModel
                {
                    Model = p.Model,
                    Image = UriComposer
                                .ComposeImageUri(db.ProductImages
                                    .FirstOrDefault(pi => pi.ProductId == p.Id)!.PhotoPath),
                    Price = 16_000_000,
                })
                .ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Detail(string Model)
        {
            var product = db.Products
                .Include(p=>p.MobileColors)
                .Include(p=>p.Brand)
                .Include(p=>p.ScreenTechnology)
                .Include(p=>p.Size)
                .Include(p=>p.SIMDesc)
                .Include(p=>p.SpecialFeatures)
                .Include(p=>p.BackGuard)
                .Include(p=>p.CommunicationNetworks)
                .Include(p=>p.InternalStorage)
                .Include(p=>p.RAM)
                .Include(p=>p.MemoryCardSupport)
                .Include(p=>p.MobileCategory)
                .Include(p=>p.CommunicationTechnologies)
                .Include(p=>p.MobileTechnologies)
                .Include(p=>p.RearCamera)
                .Include(p=>p.PhotoResolution)
                .Include(p=>p.OS)
                .Include(p=>p.Sensors)
                .Include(p=>p.Images)
                .FirstOrDefault(p => p.Model == Model);
            if (product==null)
            {
                //not found
                return RedirectToAction(nameof(Index));
            }
            var vm = new ProductPDPViewModel
            {
                Title = $"گوشی موبایل {product.Brand.Title} مدل {product.Model}",
                MobileColors=product.MobileColors.Select(c=>c.Title).ToList(),
                ProductIntroduction=product.ProductIntroduction,
                Brand=product.Brand.Title,
                Dimention=$"{product.Length} * {product.Height} * {product.Width} میلی متر",
                Weight=$"{product.Weight} گرم",
                ScreenTechnology=product.ScreenTechnology.Title,
                Size=product.Size.Title,
                ScreenResolution =$"{product.ScreenResolutionHeight} * {product.ScreenResolutionLenght}",
                ScreenPixelsPerInch=$"{product.ScreenPixelsPerInch} پیکسل بر اینچ",
                SIMDesc=product.SIMDesc.Title,
                SIMCardNumber=product.SIMCardNumber,
                BodyStructure=product.BodyStructure,
                SpecialFeatures=product.SpecialFeatures.Select(s=>s.Title).ToList(),
                IntrodutionDate=product.IntrodutionDate,
                BackGuard = product.BackGuard.Title,
                Model=product.Model,
                StoreProductID=product.StoreProductID.ToString(),
                OtherFeatures=product.OtherFeatures,
                Chip=product.Chip,
                CPU=product.CPU,
                Is64Bit=(product.Is64Bit)?"64 بیت":"32 بیت",
                CPUFrequency=product.CPUFrequency,
                GPU=product.GPU,
                CommunicationNetworks=product.CommunicationNetworks.Select(c=>c.Title).ToList(),
                InternalStorage=product.InternalStorage.Title,
                RAM=product.RAM.Title,
                MemoryCardSupport=product.MemoryCardSupport.Title,
                MobileCategory=product.MobileCategory.Title,
                CommunicationTechnologies=product.CommunicationTechnologies.Select(c=>c.Title).ToList(),
                Wifi=product.Wifi,
                Bluetooth=product.Bluetooth,
                BluetoothVersion=product.BluetoothVersion,
                MobileTechnologies=product.MobileTechnologies.Select(m=>m.Title).ToList(),
                CommunicationPorts=product.CommunicationPorts,
                RearCamera=product.RearCamera.Title,
                PhotoResolution=product.PhotoResolution.Title,
                Flash=product.Flash,
                CameraCapabilitiesDescriptions=product.CameraCapabilitiesDescriptions,
                FilmingDescriptions=product.FilmingDescriptions,
                FrontCameraDescriptions=product.FrontCameraDescriptions,
                OS=product.OS.Title,
                Sensors=product.Sensors.Select(s=>s.Title).ToList(),
                BatterySpecifications=product.BatterySpecifications,
                Images=product.Images.Select(i=>UriComposer.ComposeImageUri(i.PhotoPath)!).ToList(),
            };

            return View(vm);
        }
    }
}
