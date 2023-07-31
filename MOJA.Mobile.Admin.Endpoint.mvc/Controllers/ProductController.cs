using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using MOJA.Mobile.Admin.Endpoint.mvc.Models.Product;
using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct;
using MOJA.MobileStore.Application.Services.Products.Commands.CreateProduct.Features;
using MOJA.MobileStore.Application.Services.Products.Interfaces;
using MOJA.MobileStore.Infrastructure.Services.ImageServer;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetListProductFeaturesPattern _getListProductFeatures;
        private readonly ICreateProductService _createProductService;
        private readonly IAppDbContext db;
        public ProductController(GetListProductFeaturesPattern getListProductFeatures,
            ICreateProductService createProductService,
            IAppDbContext db)
        {
            _getListProductFeatures = getListProductFeatures;
            _createProductService = createProductService;
            this.db = db;
        }

        [HttpGet]
        public IActionResult Show()
        {
            var products = db.Products
                .Include(p=>p.ScreenTechnology)
                .Include(p=>p.Size)
                .Include(p=>p.InternalStorage)
                .Include(p=>p.RAM)
                .Select(p => new ShowProductTableViewModel
                {
                    Id=p.Id,
                    Model=p.Model,
                    ScreenTech = p.ScreenTechnology.Title,
                    Size=p.Size.Title,
                    InternalStorage =p.InternalStorage.Title,
                    Ram=p.RAM.Title,
                })
                .ToList();

            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Update(long Id)
        {
            var product = await db.Products
                .FirstOrDefaultAsync(p => p.Id == Id);
            if (product == null)
            {
                // not found
                return RedirectToAction(nameof(Show), "Product");
            }
            var phResolution = await _getListProductFeatures.GetPhotoResolutionsService.ExecuteAsync();
            var sizes = await _getListProductFeatures.GetMobileSizesService.ExecuteAsync();
            var vm = new UpdateProductViewModel
            {
                Id=product.Id,
                PhotoResolutions=new SelectList(phResolution,"Id","Title"),
                SelectedPhotoResolution=product.PhotoResolutionId,
                Sizes=new SelectList(sizes,"Id","Title"),
                SelectedSize=product.SizeId,
                Height=product.Height,
                Length=product.Length,
                Width=product.Width
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductViewModel vm)
        {
            var product = await db.Products
                .Include(p=>p.PhotoResolution)
                .Include(p=>p.Size)
                .FirstOrDefaultAsync(p => p.Id == vm.Id);
            if (product == null)
            {
                // not found
                return RedirectToAction(nameof(Show), "Product");
            }
            product.PhotoResolution = db.PhotoResolutions
                .FirstOrDefault(p => p.Id == vm.SelectedPhotoResolution)!;

            product.Size = db.MobileSizes.FirstOrDefault(p => p.Id == vm.SelectedSize)!;

            product.Length = vm.Length;
            product.Height = vm.Height;
            product.Width = vm.Width;

            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Show), "Product");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(long Id)
        {
            var product= await db.Products.FirstOrDefaultAsync(p=>p.Id==Id);
            if (product == null)
            {
                // not found
                return RedirectToAction(nameof(Show),"Product");
            }
            db.Products.Remove(product);
            await db.SaveChangesAsync();
            //delete related image from fs
            return RedirectToAction(nameof(Show), "Product");
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var colors = await _getListProductFeatures.GetMobileColorsService.ExecuteAsync();
            var brands = await _getListProductFeatures.GetBrandsService.ExecuteAsync();
            var sizes = await _getListProductFeatures.GetMobileSizesService.ExecuteAsync();
            var simDescs = await _getListProductFeatures.GetSIMDescsService.ExecuteAsync();
            var specialFeatures = await _getListProductFeatures
                .GetSpecialFeaturesService.ExecuteAsync();
            var backguards = await _getListProductFeatures.GetBackguardsService.ExecuteAsync();
            var communicationNetworks = await _getListProductFeatures
                .GetCommunicationNetworksService.ExecuteAsync();
            var rams = await _getListProductFeatures.GetMobileRamsService.ExecuteAsync();
            var categories = await _getListProductFeatures.GetMobileCategoriesService.ExecuteAsync();
            var screenTechs = await _getListProductFeatures
                .GetScreenTechnologiesService.ExecuteAsync();
            var communicationTechs = await _getListProductFeatures
                .GetCommunicationTechnologiesService.ExecuteAsync();
            var mobileTechs = await _getListProductFeatures
                .GetMobileTechnologiesService.ExecuteAsync();
            var oses = await _getListProductFeatures.GetOSsService.ExecuteAsync();
            var sensors = await _getListProductFeatures.GetSensorsService.ExecuteAsync();
            var memcardsupports = await _getListProductFeatures
                .GetMemoryCardSupportsService.ExecuteAsync();
            var rearCams = await _getListProductFeatures.GetRearCamerasService.ExecuteAsync();
            var phResolution = await _getListProductFeatures
                .GetPhotoResolutionsService.ExecuteAsync();
            var internalStorages = await _getListProductFeatures
                .GetInternalStoragesService.ExecuteAsync();

            var colorsvm = new SelectList(colors, "Id", "Title");
            var brandsvm = new SelectList(brands, "Id", "Title");
            var sizesvm = new SelectList(sizes, "Id", "Title");
            var simDescsvm = new SelectList(simDescs, "Id", "Title");
            var specialFeaturesvm = new SelectList(specialFeatures, "Id", "Title");
            var backguardsvm = new SelectList(backguards, "Id", "Title");
            var communicationNetworksvm = new SelectList(communicationNetworks, "Id", "Title");
            var ramsvm = new SelectList(rams, "Id", "Title");
            var categoriesvm = new SelectList(categories, "Id", "Title");
            var screenTechsvm = new SelectList(screenTechs, "Id", "Title");
            var communicationTechsvm = new SelectList(communicationTechs, "Id", "Title");
            var mobileTechsvm = new SelectList(mobileTechs, "Id", "Title");
            var osesvm = new SelectList(oses, "Id", "Title");
            var sensorsvm = new SelectList(sensors, "Id", "Title");
            var memcardsupportsvm = new SelectList(memcardsupports, "Id", "Title");
            var rearCamsvm = new SelectList(rearCams, "Id", "Title");
            var phResolutionvm = new SelectList(phResolution, "Id", "Title");
            var internalStoragesvm = new SelectList(internalStorages, "Id", "Title");

            var vm = new CreateProductViewModelGet(colorsvm, brandsvm, sizesvm, simDescsvm, specialFeaturesvm
                , backguardsvm, communicationNetworksvm, ramsvm, categoriesvm, screenTechsvm
                , communicationTechsvm, mobileTechsvm, osesvm, sensorsvm, memcardsupportsvm
                , rearCamsvm, phResolutionvm, internalStoragesvm);
                    
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductViewModelPost vm)
        {
            if (!ModelState.IsValid)
            {
                //
            }
            var dto = MapperCreateProductDtoViewModel.To(vm);
            var result =await _createProductService.Execute(dto);
            if (!result.IsSuccessed)
            {
                //
            }
            return RedirectToAction(nameof(Show),"Product");
        }
    }
}
