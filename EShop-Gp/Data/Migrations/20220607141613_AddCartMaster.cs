using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop_Gp.Data.Migrations
{
    public partial class AddCartMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartMasterId",
                table: "Cart",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CartMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartMaster", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartMasterId",
                table: "Cart",
                column: "CartMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_CartMaster_CartMasterId",
                table: "Cart",
                column: "CartMasterId",
                principalTable: "CartMaster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_CartMaster_CartMasterId",
                table: "Cart");

            migrationBuilder.DropTable(
                name: "CartMaster");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CartMasterId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "CartMasterId",
                table: "Cart");
        }
    }
}
