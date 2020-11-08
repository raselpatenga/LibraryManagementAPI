using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class BookSell_update_column2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellId",
                table: "BookSellDetails");

            migrationBuilder.DropColumn(
                name: "SellId",
                table: "BookSellDetails");

            migrationBuilder.AlterColumn<int>(
                name: "BookSellId",
                table: "BookSellDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellId",
                table: "BookSellDetails",
                column: "BookSellId",
                principalTable: "BookSell",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellId",
                table: "BookSellDetails");

            migrationBuilder.AlterColumn<int>(
                name: "BookSellId",
                table: "BookSellDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "SellId",
                table: "BookSellDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BookSellDetails_BookSell_BookSellId",
                table: "BookSellDetails",
                column: "BookSellId",
                principalTable: "BookSell",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
