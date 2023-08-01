using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class Cart_CartItems_SalePricePropertyToProduct_are_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Point_PointId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Point");

            migrationBuilder.DropIndex(
                name: "IX_Products_PointId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PointId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "SalesPrice",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropColumn(
                name: "SalesPrice",
                table: "Products");

            migrationBuilder.AddColumn<long>(
                name: "PointId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvgScore = table.Column<float>(type: "real", nullable: false),
                    NumberOfparticipants = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_PointId",
                table: "Products",
                column: "PointId",
                unique: true,
                filter: "[PointId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Point_PointId",
                table: "Products",
                column: "PointId",
                principalTable: "Point",
                principalColumn: "Id");
        }
    }
}
