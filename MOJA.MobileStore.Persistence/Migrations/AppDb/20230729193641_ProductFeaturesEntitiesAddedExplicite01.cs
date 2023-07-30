using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class ProductFeaturesEntitiesAddedExplicite01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunicationNetworkProduct_CommunicationNetwork_CommunicationNetworksId",
                table: "CommunicationNetworkProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunicationTechnologyProduct_CommunicationTechnology_CommunicationTechnologiesId",
                table: "CommunicationTechnologyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileColorProduct_MobileColor_MobileColorsId",
                table: "MobileColorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileSensorProduct_MobileSensor_SensorsId",
                table: "MobileSensorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileTechnologyProduct_MobileTechnology_MobileTechnologiesId",
                table: "MobileTechnologyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BackGuardMaterial_BackGuardId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_InternalStorage_InternalStorageId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MemoryCardSupport_MemoryCardSupportId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileBrand_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileCategory_MobileCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileOS_OSId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileRam_RAMId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileSize_SizeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PhotoResolution_PhotoResolutionId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_RearCamera_RearCameraId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SIMDesc_SIMDescId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ScreenTechnology_ScreenTechnologyId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecialFeature_SpecialFeature_SpecialFeaturesId",
                table: "ProductSpecialFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialFeature",
                table: "SpecialFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SIMDesc",
                table: "SIMDesc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScreenTechnology",
                table: "ScreenTechnology");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RearCamera",
                table: "RearCamera");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoResolution",
                table: "PhotoResolution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileTechnology",
                table: "MobileTechnology");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileSize",
                table: "MobileSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileSensor",
                table: "MobileSensor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileRam",
                table: "MobileRam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileOS",
                table: "MobileOS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileColor",
                table: "MobileColor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileCategory",
                table: "MobileCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileBrand",
                table: "MobileBrand");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemoryCardSupport",
                table: "MemoryCardSupport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InternalStorage",
                table: "InternalStorage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommunicationTechnology",
                table: "CommunicationTechnology");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommunicationNetwork",
                table: "CommunicationNetwork");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackGuardMaterial",
                table: "BackGuardMaterial");

            migrationBuilder.RenameTable(
                name: "SpecialFeature",
                newName: "SpecialFeatures");

            migrationBuilder.RenameTable(
                name: "SIMDesc",
                newName: "SIMDescs");

            migrationBuilder.RenameTable(
                name: "ScreenTechnology",
                newName: "ScreenTechnologies");

            migrationBuilder.RenameTable(
                name: "RearCamera",
                newName: "RearCameras");

            migrationBuilder.RenameTable(
                name: "PhotoResolution",
                newName: "PhotoResolutions");

            migrationBuilder.RenameTable(
                name: "MobileTechnology",
                newName: "MobileTechnologies");

            migrationBuilder.RenameTable(
                name: "MobileSize",
                newName: "MobileSizes");

            migrationBuilder.RenameTable(
                name: "MobileSensor",
                newName: "MobileSensors");

            migrationBuilder.RenameTable(
                name: "MobileRam",
                newName: "MobileRams");

            migrationBuilder.RenameTable(
                name: "MobileOS",
                newName: "MobileOSs");

            migrationBuilder.RenameTable(
                name: "MobileColor",
                newName: "Colors");

            migrationBuilder.RenameTable(
                name: "MobileCategory",
                newName: "MobileCategories");

            migrationBuilder.RenameTable(
                name: "MobileBrand",
                newName: "MobileBrands");

            migrationBuilder.RenameTable(
                name: "MemoryCardSupport",
                newName: "MemoryCardSupports");

            migrationBuilder.RenameTable(
                name: "InternalStorage",
                newName: "InternalStorages");

            migrationBuilder.RenameTable(
                name: "CommunicationTechnology",
                newName: "CommunicationTechnologies");

            migrationBuilder.RenameTable(
                name: "CommunicationNetwork",
                newName: "CommunicationNetworks");

            migrationBuilder.RenameTable(
                name: "BackGuardMaterial",
                newName: "BackGuards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialFeatures",
                table: "SpecialFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SIMDescs",
                table: "SIMDescs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScreenTechnologies",
                table: "ScreenTechnologies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RearCameras",
                table: "RearCameras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoResolutions",
                table: "PhotoResolutions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileTechnologies",
                table: "MobileTechnologies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileSizes",
                table: "MobileSizes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileSensors",
                table: "MobileSensors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileRams",
                table: "MobileRams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileOSs",
                table: "MobileOSs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileCategories",
                table: "MobileCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileBrands",
                table: "MobileBrands",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemoryCardSupports",
                table: "MemoryCardSupports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InternalStorages",
                table: "InternalStorages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommunicationTechnologies",
                table: "CommunicationTechnologies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommunicationNetworks",
                table: "CommunicationNetworks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackGuards",
                table: "BackGuards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommunicationNetworkProduct_CommunicationNetworks_CommunicationNetworksId",
                table: "CommunicationNetworkProduct",
                column: "CommunicationNetworksId",
                principalTable: "CommunicationNetworks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunicationTechnologyProduct_CommunicationTechnologies_CommunicationTechnologiesId",
                table: "CommunicationTechnologyProduct",
                column: "CommunicationTechnologiesId",
                principalTable: "CommunicationTechnologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileColorProduct_Colors_MobileColorsId",
                table: "MobileColorProduct",
                column: "MobileColorsId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileSensorProduct_MobileSensors_SensorsId",
                table: "MobileSensorProduct",
                column: "SensorsId",
                principalTable: "MobileSensors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileTechnologyProduct_MobileTechnologies_MobileTechnologiesId",
                table: "MobileTechnologyProduct",
                column: "MobileTechnologiesId",
                principalTable: "MobileTechnologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BackGuards_BackGuardId",
                table: "Products",
                column: "BackGuardId",
                principalTable: "BackGuards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_InternalStorages_InternalStorageId",
                table: "Products",
                column: "InternalStorageId",
                principalTable: "InternalStorages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MemoryCardSupports_MemoryCardSupportId",
                table: "Products",
                column: "MemoryCardSupportId",
                principalTable: "MemoryCardSupports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileBrands_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "MobileBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileCategories_MobileCategoryId",
                table: "Products",
                column: "MobileCategoryId",
                principalTable: "MobileCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileOSs_OSId",
                table: "Products",
                column: "OSId",
                principalTable: "MobileOSs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileRams_RAMId",
                table: "Products",
                column: "RAMId",
                principalTable: "MobileRams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileSizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "MobileSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PhotoResolutions_PhotoResolutionId",
                table: "Products",
                column: "PhotoResolutionId",
                principalTable: "PhotoResolutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_RearCameras_RearCameraId",
                table: "Products",
                column: "RearCameraId",
                principalTable: "RearCameras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SIMDescs_SIMDescId",
                table: "Products",
                column: "SIMDescId",
                principalTable: "SIMDescs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ScreenTechnologies_ScreenTechnologyId",
                table: "Products",
                column: "ScreenTechnologyId",
                principalTable: "ScreenTechnologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecialFeature_SpecialFeatures_SpecialFeaturesId",
                table: "ProductSpecialFeature",
                column: "SpecialFeaturesId",
                principalTable: "SpecialFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommunicationNetworkProduct_CommunicationNetworks_CommunicationNetworksId",
                table: "CommunicationNetworkProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_CommunicationTechnologyProduct_CommunicationTechnologies_CommunicationTechnologiesId",
                table: "CommunicationTechnologyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileColorProduct_Colors_MobileColorsId",
                table: "MobileColorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileSensorProduct_MobileSensors_SensorsId",
                table: "MobileSensorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MobileTechnologyProduct_MobileTechnologies_MobileTechnologiesId",
                table: "MobileTechnologyProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BackGuards_BackGuardId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_InternalStorages_InternalStorageId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MemoryCardSupports_MemoryCardSupportId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileBrands_BrandId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileCategories_MobileCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileOSs_OSId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileRams_RAMId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MobileSizes_SizeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_PhotoResolutions_PhotoResolutionId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_RearCameras_RearCameraId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SIMDescs_SIMDescId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ScreenTechnologies_ScreenTechnologyId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSpecialFeature_SpecialFeatures_SpecialFeaturesId",
                table: "ProductSpecialFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SpecialFeatures",
                table: "SpecialFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SIMDescs",
                table: "SIMDescs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScreenTechnologies",
                table: "ScreenTechnologies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RearCameras",
                table: "RearCameras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoResolutions",
                table: "PhotoResolutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileTechnologies",
                table: "MobileTechnologies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileSizes",
                table: "MobileSizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileSensors",
                table: "MobileSensors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileRams",
                table: "MobileRams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileOSs",
                table: "MobileOSs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileCategories",
                table: "MobileCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MobileBrands",
                table: "MobileBrands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MemoryCardSupports",
                table: "MemoryCardSupports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InternalStorages",
                table: "InternalStorages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommunicationTechnologies",
                table: "CommunicationTechnologies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CommunicationNetworks",
                table: "CommunicationNetworks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackGuards",
                table: "BackGuards");

            migrationBuilder.RenameTable(
                name: "SpecialFeatures",
                newName: "SpecialFeature");

            migrationBuilder.RenameTable(
                name: "SIMDescs",
                newName: "SIMDesc");

            migrationBuilder.RenameTable(
                name: "ScreenTechnologies",
                newName: "ScreenTechnology");

            migrationBuilder.RenameTable(
                name: "RearCameras",
                newName: "RearCamera");

            migrationBuilder.RenameTable(
                name: "PhotoResolutions",
                newName: "PhotoResolution");

            migrationBuilder.RenameTable(
                name: "MobileTechnologies",
                newName: "MobileTechnology");

            migrationBuilder.RenameTable(
                name: "MobileSizes",
                newName: "MobileSize");

            migrationBuilder.RenameTable(
                name: "MobileSensors",
                newName: "MobileSensor");

            migrationBuilder.RenameTable(
                name: "MobileRams",
                newName: "MobileRam");

            migrationBuilder.RenameTable(
                name: "MobileOSs",
                newName: "MobileOS");

            migrationBuilder.RenameTable(
                name: "MobileCategories",
                newName: "MobileCategory");

            migrationBuilder.RenameTable(
                name: "MobileBrands",
                newName: "MobileBrand");

            migrationBuilder.RenameTable(
                name: "MemoryCardSupports",
                newName: "MemoryCardSupport");

            migrationBuilder.RenameTable(
                name: "InternalStorages",
                newName: "InternalStorage");

            migrationBuilder.RenameTable(
                name: "CommunicationTechnologies",
                newName: "CommunicationTechnology");

            migrationBuilder.RenameTable(
                name: "CommunicationNetworks",
                newName: "CommunicationNetwork");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "MobileColor");

            migrationBuilder.RenameTable(
                name: "BackGuards",
                newName: "BackGuardMaterial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SpecialFeature",
                table: "SpecialFeature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SIMDesc",
                table: "SIMDesc",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScreenTechnology",
                table: "ScreenTechnology",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RearCamera",
                table: "RearCamera",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoResolution",
                table: "PhotoResolution",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileTechnology",
                table: "MobileTechnology",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileSize",
                table: "MobileSize",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileSensor",
                table: "MobileSensor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileRam",
                table: "MobileRam",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileOS",
                table: "MobileOS",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileCategory",
                table: "MobileCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileBrand",
                table: "MobileBrand",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemoryCardSupport",
                table: "MemoryCardSupport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InternalStorage",
                table: "InternalStorage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommunicationTechnology",
                table: "CommunicationTechnology",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CommunicationNetwork",
                table: "CommunicationNetwork",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MobileColor",
                table: "MobileColor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackGuardMaterial",
                table: "BackGuardMaterial",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CommunicationNetworkProduct_CommunicationNetwork_CommunicationNetworksId",
                table: "CommunicationNetworkProduct",
                column: "CommunicationNetworksId",
                principalTable: "CommunicationNetwork",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommunicationTechnologyProduct_CommunicationTechnology_CommunicationTechnologiesId",
                table: "CommunicationTechnologyProduct",
                column: "CommunicationTechnologiesId",
                principalTable: "CommunicationTechnology",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileColorProduct_MobileColor_MobileColorsId",
                table: "MobileColorProduct",
                column: "MobileColorsId",
                principalTable: "MobileColor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileSensorProduct_MobileSensor_SensorsId",
                table: "MobileSensorProduct",
                column: "SensorsId",
                principalTable: "MobileSensor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MobileTechnologyProduct_MobileTechnology_MobileTechnologiesId",
                table: "MobileTechnologyProduct",
                column: "MobileTechnologiesId",
                principalTable: "MobileTechnology",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BackGuardMaterial_BackGuardId",
                table: "Products",
                column: "BackGuardId",
                principalTable: "BackGuardMaterial",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_InternalStorage_InternalStorageId",
                table: "Products",
                column: "InternalStorageId",
                principalTable: "InternalStorage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MemoryCardSupport_MemoryCardSupportId",
                table: "Products",
                column: "MemoryCardSupportId",
                principalTable: "MemoryCardSupport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileBrand_BrandId",
                table: "Products",
                column: "BrandId",
                principalTable: "MobileBrand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileCategory_MobileCategoryId",
                table: "Products",
                column: "MobileCategoryId",
                principalTable: "MobileCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileOS_OSId",
                table: "Products",
                column: "OSId",
                principalTable: "MobileOS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileRam_RAMId",
                table: "Products",
                column: "RAMId",
                principalTable: "MobileRam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MobileSize_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "MobileSize",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_PhotoResolution_PhotoResolutionId",
                table: "Products",
                column: "PhotoResolutionId",
                principalTable: "PhotoResolution",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_RearCamera_RearCameraId",
                table: "Products",
                column: "RearCameraId",
                principalTable: "RearCamera",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SIMDesc_SIMDescId",
                table: "Products",
                column: "SIMDescId",
                principalTable: "SIMDesc",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ScreenTechnology_ScreenTechnologyId",
                table: "Products",
                column: "ScreenTechnologyId",
                principalTable: "ScreenTechnology",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSpecialFeature_SpecialFeature_SpecialFeaturesId",
                table: "ProductSpecialFeature",
                column: "SpecialFeaturesId",
                principalTable: "SpecialFeature",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
