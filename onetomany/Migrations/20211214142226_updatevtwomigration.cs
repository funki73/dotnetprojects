using Microsoft.EntityFrameworkCore.Migrations;

namespace onetomany.Migrations
{
    public partial class updatevtwomigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Chefs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Chefs");
        }
    }
}
