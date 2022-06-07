using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_Gp.Data.Migrations
{
    public partial class AddRelationCartInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "UserData",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Cart",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_UserData_CartId",
                table: "UserData",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserData_Cart_CartId",
                table: "UserData",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserData_Cart_CartId",
                table: "UserData");

            migrationBuilder.DropIndex(
                name: "IX_UserData_CartId",
                table: "UserData");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "UserData");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Cart");
        }
    }
}
