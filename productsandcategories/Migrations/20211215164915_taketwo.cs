using Microsoft.EntityFrameworkCore.Migrations;

namespace productsandcategories.Migrations
{
    public partial class taketwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Associations",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "AssociationID",
                table: "Associations",
                newName: "AssociationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "ProductID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Associations",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "AssociationId",
                table: "Associations",
                newName: "AssociationID");
        }
    }
}
