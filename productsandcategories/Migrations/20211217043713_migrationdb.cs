using Microsoft.EntityFrameworkCore.Migrations;

namespace productsandcategories.Migrations
{
    public partial class migrationdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoriesCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoriesCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoriesCategoryId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "ProductsProductId",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductsProductId",
                table: "Categories",
                column: "ProductsProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_ProductsProductId",
                table: "Categories",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_ProductsProductId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductsProductId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductsProductId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesCategoryId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoriesCategoryId",
                table: "Categories",
                column: "CategoriesCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoriesCategoryId",
                table: "Categories",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
