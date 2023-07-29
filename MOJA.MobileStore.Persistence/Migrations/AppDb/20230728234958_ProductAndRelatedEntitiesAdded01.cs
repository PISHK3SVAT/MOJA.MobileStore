using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class ProductAndRelatedEntitiesAdded01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackGuardMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackGuardMaterial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationNetwork",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationNetwork", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationTechnology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationTechnology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InternalStorage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalStorage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemoryCardSupport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemoryCardSupport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileBrand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileBrand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileColor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileColor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileRam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileRam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileSensor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileSensor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileTechnology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileTechnology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoResolution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoResolution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfparticipants = table.Column<long>(type: "bigint", nullable: false),
                    AvgScore = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RearCamera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RearCamera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScreenTechnology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenTechnology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIMDesc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMDesc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialFeature", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateOC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateOC", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointId = table.Column<long>(type: "bigint", nullable: true),
                    ProductIntroduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    ScreenTechnologyId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    ScreenResolutionHeight = table.Column<short>(type: "smallint", nullable: false),
                    ScreenResolutionLenght = table.Column<short>(type: "smallint", nullable: false),
                    ScreenPixelsPerInch = table.Column<short>(type: "smallint", nullable: false),
                    SIMDescId = table.Column<int>(type: "int", nullable: false),
                    SIMCardNumber = table.Column<short>(type: "smallint", nullable: false),
                    BodyStructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IntrodutionDate = table.Column<DateTime>(type: "date", nullable: false),
                    BackGuardId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtherFeatures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUFrequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is64Bit = table.Column<bool>(type: "bit", nullable: false),
                    GPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalStorageId = table.Column<int>(type: "int", nullable: false),
                    RAMId = table.Column<int>(type: "int", nullable: false),
                    MemoryCardSupportId = table.Column<int>(type: "int", nullable: false),
                    MobileCategoryId = table.Column<int>(type: "int", nullable: false),
                    Wifi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bluetooth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BluetoothVersion = table.Column<float>(type: "real", nullable: false),
                    CommunicationPorts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RearCameraId = table.Column<int>(type: "int", nullable: false),
                    PhotoResolutionId = table.Column<int>(type: "int", nullable: false),
                    Flash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CameraCapabilitiesDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmingDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrontCameraDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OSId = table.Column<int>(type: "int", nullable: false),
                    BatterySpecifications = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_BackGuardMaterial_BackGuardId",
                        column: x => x.BackGuardId,
                        principalTable: "BackGuardMaterial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_InternalStorage_InternalStorageId",
                        column: x => x.InternalStorageId,
                        principalTable: "InternalStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MemoryCardSupport_MemoryCardSupportId",
                        column: x => x.MemoryCardSupportId,
                        principalTable: "MemoryCardSupport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MobileBrand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "MobileBrand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MobileCategory_MobileCategoryId",
                        column: x => x.MobileCategoryId,
                        principalTable: "MobileCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MobileOS_OSId",
                        column: x => x.OSId,
                        principalTable: "MobileOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MobileRam_RAMId",
                        column: x => x.RAMId,
                        principalTable: "MobileRam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_MobileSize_SizeId",
                        column: x => x.SizeId,
                        principalTable: "MobileSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_PhotoResolution_PhotoResolutionId",
                        column: x => x.PhotoResolutionId,
                        principalTable: "PhotoResolution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Point_PointId",
                        column: x => x.PointId,
                        principalTable: "Point",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_RearCamera_RearCameraId",
                        column: x => x.RearCameraId,
                        principalTable: "RearCamera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SIMDesc_SIMDescId",
                        column: x => x.SIMDescId,
                        principalTable: "SIMDesc",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ScreenTechnology_ScreenTechnologyId",
                        column: x => x.ScreenTechnologyId,
                        principalTable: "ScreenTechnology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateOCId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_StateOC_StateOCId",
                        column: x => x.StateOCId,
                        principalTable: "StateOC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Person_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comment_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationNetworkProduct",
                columns: table => new
                {
                    CommunicationNetworksId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationNetworkProduct", x => new { x.CommunicationNetworksId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CommunicationNetworkProduct_CommunicationNetwork_CommunicationNetworksId",
                        column: x => x.CommunicationNetworksId,
                        principalTable: "CommunicationNetwork",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommunicationNetworkProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommunicationTechnologyProduct",
                columns: table => new
                {
                    CommunicationTechnologiesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunicationTechnologyProduct", x => new { x.CommunicationTechnologiesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CommunicationTechnologyProduct_CommunicationTechnology_CommunicationTechnologiesId",
                        column: x => x.CommunicationTechnologiesId,
                        principalTable: "CommunicationTechnology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommunicationTechnologyProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MobileColorProduct",
                columns: table => new
                {
                    MobileColorsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileColorProduct", x => new { x.MobileColorsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_MobileColorProduct_MobileColor_MobileColorsId",
                        column: x => x.MobileColorsId,
                        principalTable: "MobileColor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MobileColorProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MobileSensorProduct",
                columns: table => new
                {
                    ProductsId = table.Column<long>(type: "bigint", nullable: false),
                    SensorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileSensorProduct", x => new { x.ProductsId, x.SensorsId });
                    table.ForeignKey(
                        name: "FK_MobileSensorProduct_MobileSensor_SensorsId",
                        column: x => x.SensorsId,
                        principalTable: "MobileSensor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MobileSensorProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MobileTechnologyProduct",
                columns: table => new
                {
                    MobileTechnologiesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileTechnologyProduct", x => new { x.MobileTechnologiesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_MobileTechnologyProduct_MobileTechnology_MobileTechnologiesId",
                        column: x => x.MobileTechnologiesId,
                        principalTable: "MobileTechnology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MobileTechnologyProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecialFeature",
                columns: table => new
                {
                    ProductsId = table.Column<long>(type: "bigint", nullable: false),
                    SpecialFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecialFeature", x => new { x.ProductsId, x.SpecialFeaturesId });
                    table.ForeignKey(
                        name: "FK_ProductSpecialFeature_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSpecialFeature_SpecialFeature_SpecialFeaturesId",
                        column: x => x.SpecialFeaturesId,
                        principalTable: "SpecialFeature",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProductId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Person_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Plaque = table.Column<short>(type: "smallint", nullable: false),
                    Unit = table.Column<short>(type: "smallint", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Person_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_StateOC_StateId",
                        column: x => x.StateId,
                        principalTable: "StateOC",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    PersonId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    QuestionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Answer_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_PersonId1",
                table: "Answer",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateOCId",
                table: "City",
                column: "StateOCId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CustomerId1",
                table: "Comment",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationNetworkProduct_ProductsId",
                table: "CommunicationNetworkProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunicationTechnologyProduct_ProductsId",
                table: "CommunicationTechnologyProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CityId",
                table: "CustomerAddress",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId1",
                table: "CustomerAddress",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_StateId",
                table: "CustomerAddress",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileColorProduct_ProductsId",
                table: "MobileColorProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileSensorProduct_SensorsId",
                table: "MobileSensorProduct",
                column: "SensorsId");

            migrationBuilder.CreateIndex(
                name: "IX_MobileTechnologyProduct_ProductsId",
                table: "MobileTechnologyProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BackGuardId",
                table: "Products",
                column: "BackGuardId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_InternalStorageId",
                table: "Products",
                column: "InternalStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MemoryCardSupportId",
                table: "Products",
                column: "MemoryCardSupportId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MobileCategoryId",
                table: "Products",
                column: "MobileCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OSId",
                table: "Products",
                column: "OSId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PhotoResolutionId",
                table: "Products",
                column: "PhotoResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PointId",
                table: "Products",
                column: "PointId",
                unique: true,
                filter: "[PointId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RAMId",
                table: "Products",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_RearCameraId",
                table: "Products",
                column: "RearCameraId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ScreenTechnologyId",
                table: "Products",
                column: "ScreenTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SIMDescId",
                table: "Products",
                column: "SIMDescId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecialFeature_SpecialFeaturesId",
                table: "ProductSpecialFeature",
                column: "SpecialFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_CustomerId1",
                table: "Question",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ProductId",
                table: "Question",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "CommunicationNetworkProduct");

            migrationBuilder.DropTable(
                name: "CommunicationTechnologyProduct");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "MobileColorProduct");

            migrationBuilder.DropTable(
                name: "MobileSensorProduct");

            migrationBuilder.DropTable(
                name: "MobileTechnologyProduct");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ProductSpecialFeature");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "CommunicationNetwork");

            migrationBuilder.DropTable(
                name: "CommunicationTechnology");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "MobileColor");

            migrationBuilder.DropTable(
                name: "MobileSensor");

            migrationBuilder.DropTable(
                name: "MobileTechnology");

            migrationBuilder.DropTable(
                name: "SpecialFeature");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "StateOC");

            migrationBuilder.DropTable(
                name: "BackGuardMaterial");

            migrationBuilder.DropTable(
                name: "InternalStorage");

            migrationBuilder.DropTable(
                name: "MemoryCardSupport");

            migrationBuilder.DropTable(
                name: "MobileBrand");

            migrationBuilder.DropTable(
                name: "MobileCategory");

            migrationBuilder.DropTable(
                name: "MobileOS");

            migrationBuilder.DropTable(
                name: "MobileRam");

            migrationBuilder.DropTable(
                name: "MobileSize");

            migrationBuilder.DropTable(
                name: "PhotoResolution");

            migrationBuilder.DropTable(
                name: "Point");

            migrationBuilder.DropTable(
                name: "RearCamera");

            migrationBuilder.DropTable(
                name: "SIMDesc");

            migrationBuilder.DropTable(
                name: "ScreenTechnology");
        }
    }
}
