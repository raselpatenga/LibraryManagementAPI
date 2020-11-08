using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations
{
    public partial class BookSell_new_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookSell",
                columns: table => new
                {
                    SellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    dtSell = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookSell", x => x.SellId);
                });

            migrationBuilder.CreateTable(
                name: "BookSellDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    BookSellSellId = table.Column<int>(nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    Discount = table.Column<float>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    Paid = table.Column<float>(nullable: false),
                    Due = table.Column<float>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookSellDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookSellDetails_tblBook_BookId",
                        column: x => x.BookId,
                        principalTable: "tblBook",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookSellDetails_BookSell_BookSellSellId",
                        column: x => x.BookSellSellId,
                        principalTable: "BookSell",
                        principalColumn: "SellId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookSellDetails_BookId",
                table: "BookSellDetails",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookSellDetails_BookSellSellId",
                table: "BookSellDetails",
                column: "BookSellSellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookSellDetails");

            migrationBuilder.DropTable(
                name: "BookSell");
        }
    }
}
