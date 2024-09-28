using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nursery.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_PurchaseInvoices_PurchaseInvoiceId",
                table: "Plants");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoicePlants_Plants_PlantId",
                table: "SaleInvoicePlants");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoicePlants_SaleInvoices_SaleInvoiceId",
                table: "SaleInvoicePlants");

            migrationBuilder.DropIndex(
                name: "IX_Plants_PurchaseInvoiceId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "PurchaseInvoiceId",
                table: "Plants");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoicePlants_Plants_PlantId",
                table: "SaleInvoicePlants",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoicePlants_SaleInvoices_SaleInvoiceId",
                table: "SaleInvoicePlants",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "SaleInvoiceId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoicePlants_Plants_PlantId",
                table: "SaleInvoicePlants");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoicePlants_SaleInvoices_SaleInvoiceId",
                table: "SaleInvoicePlants");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseInvoiceId",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Plants_PurchaseInvoiceId",
                table: "Plants",
                column: "PurchaseInvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_PurchaseInvoices_PurchaseInvoiceId",
                table: "Plants",
                column: "PurchaseInvoiceId",
                principalTable: "PurchaseInvoices",
                principalColumn: "PurchaseInvoiceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoicePlants_Plants_PlantId",
                table: "SaleInvoicePlants",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoicePlants_SaleInvoices_SaleInvoiceId",
                table: "SaleInvoicePlants",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "SaleInvoiceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
