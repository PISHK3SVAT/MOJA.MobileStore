using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NullableNationalCodePersonIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NationalCode",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                table: "AspNetUsers",
                type: "nchar(20)",
                fixedLength: true,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nchar(20)",
                oldFixedLength: true,
                oldMaxLength: 20);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NationalCode",
                table: "AspNetUsers",
                column: "NationalCode",
                unique: true,
                filter: "[NationalCode] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NationalCode",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                table: "AspNetUsers",
                type: "nchar(20)",
                fixedLength: true,
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nchar(20)",
                oldFixedLength: true,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NationalCode",
                table: "AspNetUsers",
                column: "NationalCode",
                unique: true);
        }
    }
}
