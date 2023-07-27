using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AdminSeedIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c25eb38a-f9b8-41a3-ab97-70d871fbb225", "c25eb38a-f9b8-41a3-ab97-70d871fbb225", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Family", "LockoutEnabled", "LockoutEnd", "Name", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhotoPath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b659e8f0-2663-48ac-8c3e-d5ef3726ba92", 0, "063e8665-8ea8-448d-ae34-adccfc005ee0", "Admin", "mjek@gmail.com", true, "ابراهیمی", false, null, "محمد جواد", null, "MJEK@GMAIL.COM", "MJEK@GMAIL.COM", "AQAAAAIAAYagAAAAEC2cjSmXfI0JK3xeZ1axdrbKy9g/9GKzCBeBb4rshbUps4eKrMUiooJFmch67slnPg==", null, false, null, "9d3416d7-0203-4b21-9f0b-3c9bd4e93536", false, "mjek@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c25eb38a-f9b8-41a3-ab97-70d871fbb225", "b659e8f0-2663-48ac-8c3e-d5ef3726ba92" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c25eb38a-f9b8-41a3-ab97-70d871fbb225", "b659e8f0-2663-48ac-8c3e-d5ef3726ba92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c25eb38a-f9b8-41a3-ab97-70d871fbb225");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b659e8f0-2663-48ac-8c3e-d5ef3726ba92");
        }
    }
}
