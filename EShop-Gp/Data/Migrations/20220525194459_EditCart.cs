using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_Gp.Data.Migrations
{
    public partial class EditCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Cart",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cart",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cart");
        }
    }
}
