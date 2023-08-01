using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MOJA.MobileStore.Persistence.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class customerId_of_entity_become_string : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Person_PersonId1",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Person_CustomerId1",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Person_CustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Person_CustomerId1",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_CustomerId1",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_CustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropIndex(
                name: "IX_Comment_CustomerId1",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Answer_PersonId1",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "CustomerAddress");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "Answer");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Question",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "CustomerAddress",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "Answer",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_Question_CustomerId",
                table: "Question",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CustomerId",
                table: "Comment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_PersonId",
                table: "Answer",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Person_PersonId",
                table: "Answer",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Person_CustomerId",
                table: "Comment",
                column: "CustomerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Person_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Person_CustomerId",
                table: "Question",
                column: "CustomerId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Person_PersonId",
                table: "Answer");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Person_CustomerId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Person_CustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Person_CustomerId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_CustomerId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropIndex(
                name: "IX_Comment_CustomerId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Answer_PersonId",
                table: "Answer");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Question",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId1",
                table: "Question",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "CustomerAddress",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId1",
                table: "CustomerAddress",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Comment",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId1",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Carts",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "PersonId",
                table: "Answer",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "PersonId1",
                table: "Answer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_CustomerId1",
                table: "Question",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId1",
                table: "CustomerAddress",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CustomerId1",
                table: "Comment",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_PersonId1",
                table: "Answer",
                column: "PersonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Person_PersonId1",
                table: "Answer",
                column: "PersonId1",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Person_CustomerId1",
                table: "Comment",
                column: "CustomerId1",
                principalTable: "Person",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Person_CustomerId1",
                table: "CustomerAddress",
                column: "CustomerId1",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Person_CustomerId1",
                table: "Question",
                column: "CustomerId1",
                principalTable: "Person",
                principalColumn: "Id");
        }
    }
}
