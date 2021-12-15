using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace onetomany.Migrations
{
    public partial class updatevfourmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpatedAt",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "UpatedAt",
                table: "Chefs");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Dishes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "Chefs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "Chefs");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpatedAt",
                table: "Dishes",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpatedAt",
                table: "Chefs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
