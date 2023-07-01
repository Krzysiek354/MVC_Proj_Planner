using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_MVC.Migrations
{
    /// <inheritdoc />
    public partial class nowa2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Persons_PersonId",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_Work_Persons_PersonId",
                table: "Work");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Work",
                table: "Work");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shop",
                table: "Shop");

            migrationBuilder.RenameTable(
                name: "Work",
                newName: "Works");

            migrationBuilder.RenameTable(
                name: "Shop",
                newName: "Shops");

            migrationBuilder.RenameIndex(
                name: "IX_Work_PersonId",
                table: "Works",
                newName: "IX_Works_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Shop_PersonId",
                table: "Shops",
                newName: "IX_Shops_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Homework",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Works",
                table: "Works",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shops",
                table: "Shops",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_Persons_PersonId",
                table: "Shops",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Works_Persons_PersonId",
                table: "Works",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shops_Persons_PersonId",
                table: "Shops");

            migrationBuilder.DropForeignKey(
                name: "FK_Works_Persons_PersonId",
                table: "Works");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Works",
                table: "Works");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shops",
                table: "Shops");

            migrationBuilder.RenameTable(
                name: "Works",
                newName: "Work");

            migrationBuilder.RenameTable(
                name: "Shops",
                newName: "Shop");

            migrationBuilder.RenameIndex(
                name: "IX_Works_PersonId",
                table: "Work",
                newName: "IX_Work_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Shops_PersonId",
                table: "Shop",
                newName: "IX_Shop_PersonId");

            migrationBuilder.AlterColumn<int>(
                name: "Homework",
                table: "Schools",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Work",
                table: "Work",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shop",
                table: "Shop",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Persons_PersonId",
                table: "Shop",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Work_Persons_PersonId",
                table: "Work",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id");
        }
    }
}
