using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASU_IS_19_03.Migrations
{
    public partial class Ver1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                });

            migrationBuilder.CreateTable(
                name: "Sklads",
                columns: table => new
                {
                    SkladId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sklads", x => x.SkladId);
                });

            migrationBuilder.CreateTable(
                name: "TypePrinters",
                columns: table => new
                {
                    TypePrinterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePrinters", x => x.TypePrinterId);
                });

            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    PrinterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    TypePrinterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.PrinterId);
                    table.ForeignKey(
                        name: "FK_Printers_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "ManufacturerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Printers_TypePrinters_TypePrinterId",
                        column: x => x.TypePrinterId,
                        principalTable: "TypePrinters",
                        principalColumn: "TypePrinterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrinterSklads",
                columns: table => new
                {
                    PrinterSkladId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Date_of_operation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Operation = table.Column<bool>(type: "bit", nullable: false),
                    PrinterId = table.Column<int>(type: "int", nullable: false),
                    SkladId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterSklads", x => x.PrinterSkladId);
                    table.ForeignKey(
                        name: "FK_PrinterSklads_Printers_PrinterId",
                        column: x => x.PrinterId,
                        principalTable: "Printers",
                        principalColumn: "PrinterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrinterSklads_Sklads_SkladId",
                        column: x => x.SkladId,
                        principalTable: "Sklads",
                        principalColumn: "SkladId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Printers_ManufacturerId",
                table: "Printers",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Printers_TypePrinterId",
                table: "Printers",
                column: "TypePrinterId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterSklads_PrinterId",
                table: "PrinterSklads",
                column: "PrinterId");

            migrationBuilder.CreateIndex(
                name: "IX_PrinterSklads_SkladId",
                table: "PrinterSklads",
                column: "SkladId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrinterSklads");

            migrationBuilder.DropTable(
                name: "Printers");

            migrationBuilder.DropTable(
                name: "Sklads");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "TypePrinters");
        }
    }
}
