using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueFromNationalCodePersonIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NationalCode",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NationalCode",
                table: "AspNetUsers",
                column: "NationalCode",
                unique: true,
                filter: "[NationalCode] IS NOT NULL");
        }
    }
}
