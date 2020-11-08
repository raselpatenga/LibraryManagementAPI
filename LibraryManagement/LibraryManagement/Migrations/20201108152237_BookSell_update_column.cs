using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class BookSell_update_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellSellId",
                table: "BookSellDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookSellDetails_BookSellSellId",
                table: "BookSellDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookSell",
                table: "BookSell");

            migrationBuilder.DropColumn(
                name: "BookSellSellId",
                table: "BookSellDetails");

            migrationBuilder.DropColumn(
                name: "SellId",
                table: "BookSell");

            migrationBuilder.AddColumn<int>(
                name: "BookSellId",
                table: "BookSellDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookSell",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookSell",
                table: "BookSell",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BookSellDetails_BookSellId",
                table: "BookSellDetails",
                column: "BookSellId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellId",
                table: "BookSellDetails",
                column: "BookSellId",
                principalTable: "BookSell",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellId",
                table: "BookSellDetails");

            migrationBuilder.DropIndex(
                name: "IX_BookSellDetails_BookSellId",
                table: "BookSellDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookSell",
                table: "BookSell");

            migrationBuilder.DropColumn(
                name: "BookSellId",
                table: "BookSellDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookSell");

            migrationBuilder.AddColumn<int>(
                name: "BookSellSellId",
                table: "BookSellDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellId",
                table: "BookSell",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookSell",
                table: "BookSell",
                column: "SellId");

            migrationBuilder.CreateIndex(
                name: "IX_BookSellDetails_BookSellSellId",
                table: "BookSellDetails",
                column: "BookSellSellId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellSellId",
                table: "BookSellDetails",
                column: "BookSellSellId",
                principalTable: "BookSell",
                principalColumn: "SellId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
