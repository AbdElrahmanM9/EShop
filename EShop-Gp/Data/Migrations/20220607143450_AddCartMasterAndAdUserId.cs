using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_Gp.Data.Migrations
{
    public partial class AddCartMasterAndAdUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "CartMaster",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CartMaster",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "CartMaster");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CartMaster");
        }
    }
}
