using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nursery.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addplantIdtosalepurchinvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarcodePlant",
                table: "SectorPlants");

            migrationBuilder.DropColumn(
                name: "BarcodePlant",
                table: "SaleInvoicePlants");

            migrationBuilder.RenameColumn(
                name: "CurrencyCode",
                table: "SaleInvoices",
                newName: "CurrencyCodePlant");

            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "SaleInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "PurchaseInvoices",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "SaleInvoices");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "PurchaseInvoices");

            migrationBuilder.RenameColumn(
                name: "CurrencyCodePlant",
                table: "SaleInvoices",
                newName: "CurrencyCode");

            migrationBuilder.AddColumn<string>(
                name: "BarcodePlant",
                table: "SectorPlants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BarcodePlant",
                table: "SaleInvoicePlants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
