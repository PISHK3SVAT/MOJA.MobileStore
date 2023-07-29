using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePersonAndRelatedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_OwnerId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_StateOCs_StateId",
                schema: "Customer",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "StateId",
                schema: "Customer",
                table: "Cities",
                newName: "StateOCId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateId",
                schema: "Customer",
                table: "Cities",
                newName: "IX_Cities_StateOCId");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                schema: "Customer",
                table: "Addresses",
                newName: "CustomerId1");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_OwnerId",
                schema: "Customer",
                table: "Addresses",
                newName: "IX_Addresses_CustomerId1");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId",
                schema: "Customer",
                table: "Addresses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "StateOCId",
                schema: "Customer",
                table: "Addresses",
                type: "int",
                nullable: true);

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_CustomerId1",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_StateOCs_StateOCId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_StateOCs_StateOCId",
                schema: "Customer",
                table: "Cities");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_StateOCId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "StateOCId",
                schema: "Customer",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "StateOCId",
                schema: "Customer",
                table: "Cities",
                newName: "StateId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateOCId",
                schema: "Customer",
                table: "Cities",
                newName: "IX_Cities_StateId");

            migrationBuilder.RenameColumn(
                name: "CustomerId1",
                schema: "Customer",
                table: "Addresses",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CustomerId1",
                schema: "Customer",
                table: "Addresses",
                newName: "IX_Addresses_OwnerId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b659e8f0-2663-48ac-8c3e-d5ef3726ba92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "063e8665-8ea8-448d-ae34-adccfc005ee0", "AQAAAAIAAYagAAAAEC2cjSmXfI0JK3xeZ1axdrbKy9g/9GKzCBeBb4rshbUps4eKrMUiooJFmch67slnPg==", "9d3416d7-0203-4b21-9f0b-3c9bd4e93536" });

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_OwnerId",
                schema: "Customer",
                table: "Addresses",
                column: "OwnerId",
                principalTable: "AspNetUsers",
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
    }
}
