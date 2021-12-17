using Microsoft.EntityFrameworkCore.Migrations;

namespace productsandcategories.Migrations
{
    public partial class migratevfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesCategoryId",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatwithProdCategoryId",
                table: "Associations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdwithCatProductId",
                table: "Associations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoriesCategoryId",
                table: "Categories",
                column: "CategoriesCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_CatwithProdCategoryId",
                table: "Associations",
                column: "CatwithProdCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Associations_ProdwithCatProductId",
                table: "Associations",
                column: "ProdwithCatProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_CatwithProdCategoryId",
                table: "Associations",
                column: "CatwithProdCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Products_ProdwithCatProductId",
                table: "Associations",
                column: "ProdwithCatProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoriesCategoryId",
                table: "Categories",
                column: "CategoriesCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_CatwithProdCategoryId",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Products_ProdwithCatProductId",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoriesCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoriesCategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Associations_CatwithProdCategoryId",
                table: "Associations");

            migrationBuilder.DropIndex(
                name: "IX_Associations_ProdwithCatProductId",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "CategoriesCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CatwithProdCategoryId",
                table: "Associations");

            migrationBuilder.DropColumn(
                name: "ProdwithCatProductId",
                table: "Associations");
        }
    }
}
