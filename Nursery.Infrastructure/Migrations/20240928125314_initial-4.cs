using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nursery.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Plants_PlantId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_PlantId",
                table: "Stores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Stores_PlantId",
                table: "Stores",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Plants_PlantId",
                table: "Stores",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
