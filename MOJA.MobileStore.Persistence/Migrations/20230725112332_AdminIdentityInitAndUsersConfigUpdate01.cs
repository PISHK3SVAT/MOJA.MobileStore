using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdminIdentityInitAndUsersConfigUpdate01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_StateOC_StateId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_AspNetUsers_OwnerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_City_CityId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_StateOC_StateId",
                table: "CustomerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateOC",
                table: "StateOC");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.EnsureSchema(
                name: "Customer");

            migrationBuilder.RenameTable(
                name: "StateOC",
                newName: "StateOCs",
                newSchema: "Customer");

            migrationBuilder.RenameTable(
                name: "CustomerAddress",
                newName: "Addresses",
                newSchema: "Customer");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities",
                newSchema: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAddress_StateId",
                schema: "Customer",
                table: "Addresses",
                newName: "IX_Addresses_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAddress_OwnerId",
                schema: "Customer",
                table: "Addresses",
                newName: "IX_Addresses_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAddress_CityId",
                schema: "Customer",
                table: "Addresses",
                newName: "IX_Addresses_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_City_StateId",
                schema: "Customer",
                table: "Cities",
                newName: "IX_Cities_StateId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateOCs",
                schema: "Customer",
                table: "StateOCs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                schema: "Customer",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                schema: "Customer",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_OwnerId",
                schema: "Customer",
                table: "Addresses",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                schema: "Customer",
                table: "Addresses",
                column: "CityId",
                principalSchema: "Customer",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_StateOCs_StateId",
                schema: "Customer",
                table: "Addresses",
                column: "StateId",
                principalSchema: "Customer",
                principalTable: "StateOCs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_StateOCs_StateId",
                schema: "Customer",
                table: "Cities",
                column: "StateId",
                principalSchema: "Customer",
                principalTable: "StateOCs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_OwnerId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_StateOCs_StateId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_StateOCs_StateId",
                schema: "Customer",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateOCs",
                schema: "Customer",
                table: "StateOCs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                schema: "Customer",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "StateOCs",
                schema: "Customer",
                newName: "StateOC");

            migrationBuilder.RenameTable(
                name: "Cities",
                schema: "Customer",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "Addresses",
                schema: "Customer",
                newName: "CustomerAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateId",
                table: "City",
                newName: "IX_City_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_StateId",
                table: "CustomerAddress",
                newName: "IX_CustomerAddress_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_OwnerId",
                table: "CustomerAddress",
                newName: "IX_CustomerAddress_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CityId",
                table: "CustomerAddress",
                newName: "IX_CustomerAddress_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateOC",
                table: "StateOC",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_StateOC_StateId",
                table: "City",
                column: "StateId",
                principalTable: "StateOC",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_AspNetUsers_OwnerId",
                table: "CustomerAddress",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_City_CityId",
                table: "CustomerAddress",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_StateOC_StateId",
                table: "CustomerAddress",
                column: "StateId",
                principalTable: "StateOC",
                principalColumn: "Id");
        }
    }
}
