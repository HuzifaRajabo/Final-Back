using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nursery.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inetial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseInvoices",
                columns: table => new
                {
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoices", x => x.PurchaseInvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoices",
                columns: table => new
                {
                    SaleInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoices", x => x.SaleInvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    SectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.SectorId);
                });

            migrationBuilder.CreateTable(
                name: "Kinds",
                columns: table => new
                {
                    KindId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KindName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kinds", x => x.KindId);
                    table.ForeignKey(
                        name: "FK_Kinds_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kinds_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceSel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisposalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PurchaseInvoiceId = table.Column<int>(type: "int", nullable: false),
                    kindId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.PlantId);
                    table.ForeignKey(
                        name: "FK_Plants_Kinds_kindId",
                        column: x => x.kindId,
                        principalTable: "Kinds",
                        principalColumn: "KindId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plants_PurchaseInvoices_PurchaseInvoiceId",
                        column: x => x.PurchaseInvoiceId,
                        principalTable: "PurchaseInvoices",
                        principalColumn: "PurchaseInvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoicePlants",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    SaleInvoiceId = table.Column<int>(type: "int", nullable: false),
                    BarcodePlant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoicePlants", x => new { x.SaleInvoiceId, x.PlantId });
                    table.ForeignKey(
                        name: "FK_SaleInvoicePlants_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleInvoicePlants_SaleInvoices_SaleInvoiceId",
                        column: x => x.SaleInvoiceId,
                        principalTable: "SaleInvoices",
                        principalColumn: "SaleInvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SectorPlants",
                columns: table => new
                {
                    PlantId = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    BarcodePlant = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorPlants", x => new { x.SectorId, x.PlantId });
                    table.ForeignKey(
                        name: "FK_SectorPlants_Plants_PlantId",
                        column: x => x.PlantId,
                        principalTable: "Plants",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SectorPlants_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "SectorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kinds_CategoryId",
                table: "Kinds",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kinds_SectorId",
                table: "Kinds",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_kindId",
                table: "Plants",
                column: "kindId");

            migrationBuilder.CreateIndex(
                name: "IX_Plants_PurchaseInvoiceId",
                table: "Plants",
                column: "PurchaseInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoicePlants_PlantId",
                table: "SaleInvoicePlants",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_SectorPlants_PlantId",
                table: "SectorPlants",
                column: "PlantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleInvoicePlants");

            migrationBuilder.DropTable(
                name: "SectorPlants");

            migrationBuilder.DropTable(
                name: "SaleInvoices");

            migrationBuilder.DropTable(
                name: "Plants");

            migrationBuilder.DropTable(
                name: "Kinds");

            migrationBuilder.DropTable(
                name: "PurchaseInvoices");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sectors");
        }
    }
}
