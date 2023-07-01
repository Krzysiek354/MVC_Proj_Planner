using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_MVC.Migrations
{
    /// <inheritdoc />
    public partial class nowa1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enjoy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Idea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKid = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enjoy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enjoy_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    IdKid = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shop_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Work",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    When = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKid = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Work", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Work_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enjoy_PersonId",
                table: "Enjoy",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_PersonId",
                table: "Shop",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_PersonId",
                table: "Work",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enjoy");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "Work");
        }
    }
}
