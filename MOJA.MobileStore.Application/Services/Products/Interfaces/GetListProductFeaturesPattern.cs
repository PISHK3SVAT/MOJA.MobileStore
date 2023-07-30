using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetBackguards;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetBrands;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetCommunicationNetworks;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetCommunicationTechnologies;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetInternalStorages;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMemoryCardSupports;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileCategories;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileColors;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetMobileTechnologies;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetOSs;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetPhotoResolutions;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetRams;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetRearCameras;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetScreenTechnologies;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSensors;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSIMDescs;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSizes;
using MOJA.MobileStore.Application.Services.Products.Queries.ProductFeatures.GetSpecialFeatures;

namespace MOJA.MobileStore.Application.Services.Products.Interfaces
{
    public class GetListProductFeaturesPattern
    {
        private readonly IAppDbContext _db;

        public GetListProductFeaturesPattern(IAppDbContext db)
        {
            _db = db;
        }
        private readonly IGetBackguardsService _getBackguardsService;
        public IGetBackguardsService GetBackguardsService {
            get => _getBackguardsService ?? new GetBackguardService(_db);
        }

        private readonly IGetBrandsService _getBrandsService;
        public IGetBrandsService GetBrandsService
        {
            get => _getBrandsService ?? new GetBrandsService(_db);
        }

        private readonly IGetCommunicationNetworksService _getCommunicationNetworksService;
        public IGetCommunicationNetworksService GetCommunicationNetworksService
        {
            get => _getCommunicationNetworksService ?? new GetCommunicationNetworksService(_db);
        }

        private readonly IGetCommunicationTechnologiesService _getCommunicationTechnologiesService;
        public IGetCommunicationTechnologiesService GetCommunicationTechnologiesService
        {
            get => _getCommunicationTechnologiesService ?? new GetCommunicationTechnologiesService(_db);
        }

        private readonly IGetInternalStoragesService _getInternalStoragesService;
        public IGetInternalStoragesService GetInternalStoragesService
        {
            get => _getInternalStoragesService ?? new GetInternalStoragesService(_db);
        }

        private readonly IGetMemoryCardSupportsService _getMemoryCardSupportsService;
        public IGetMemoryCardSupportsService GetMemoryCardSupportsService
        {
            get => _getMemoryCardSupportsService ?? new GetMemoryCardSupportsService(_db);
        }

        private readonly IGetMobileCategoriesService _getMobileCategoriesService;
        public IGetMobileCategoriesService GetMobileCategoriesService
        {
            get => _getMobileCategoriesService ?? new GetMobileCategoriesService(_db);
        }

        private readonly IGetMobileColorsService _getMobileColorsService;
        public IGetMobileColorsService GetMobileColorsService
        {
            get => _getMobileColorsService ?? new GetMobileColorsService(_db);
        }

        private readonly IGetMobileTechnologiesService _getMobileTechnologiesService;
        public IGetMobileTechnologiesService GetMobileTechnologiesService
        {
            get => _getMobileTechnologiesService ?? new GetMobileTechnologiesService(_db);
        }

        private readonly IGetOSsService _getOSsService;
        public IGetOSsService GetOSsService
        {
            get => _getOSsService ?? new GetOSsService(_db);
        }

        private readonly IGetPhotoResolutionsService _getPhotoResolutionsService;
        public IGetPhotoResolutionsService GetPhotoResolutionsService
        {
            get => _getPhotoResolutionsService ?? new GetPhotoResolutionsService(_db);
        }

        private readonly IGetMobileRamsService _getMobileRamsService;
        public IGetMobileRamsService GetMobileRamsService
        {
            get => _getMobileRamsService ?? new GetMobileRamsService(_db);
        }

        private readonly IGetRearCamerasService _getRearCamerasService;
        public IGetRearCamerasService GetRearCamerasService
        {
            get => _getRearCamerasService ?? new GetRearCamerasService(_db);
        }

        private readonly IGetScreenTechnologiesService _getScreenTechnologiesService;
        public IGetScreenTechnologiesService GetScreenTechnologiesService
        {
            get => _getScreenTechnologiesService ?? new GetScreenTechnologiesService(_db);
        }

        private readonly IGetSensorsService _getSensorsService;
        public IGetSensorsService GetSensorsService
        {
            get => _getSensorsService ?? new GetSensorsService(_db);
        }

        private readonly IGetSIMDescsService _getSIMDescsService;
        public IGetSIMDescsService GetSIMDescsService
        {
            get => _getSIMDescsService ?? new GetSIMDescsService(_db);
        }

        private readonly IGetMobileSizesService _getMobileSizesService;
        public IGetMobileSizesService GetMobileSizesService
        {
            get => _getMobileSizesService ?? new GetMobileSizesService(_db);
        }

        private readonly IGetSpecialFeaturesService _getSpecialFeaturesService;
        public IGetSpecialFeaturesService GetSpecialFeaturesService
        {
            get => _getSpecialFeaturesService ?? new GetSpecialFeaturesService(_db);
        }

    }
}
