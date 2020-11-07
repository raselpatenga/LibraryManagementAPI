using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Migrations.BookSell
{
    public partial class initial_bookSell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblBoolSell",
                columns: table => new
                {
                    SellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    dtSell = table.Column<DateTime>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Discount = table.Column<float>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    Paid = table.Column<float>(nullable: false),
                    Due = table.Column<float>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblBoolSell", x => x.SellId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblBoolSell");
        }
    }
}
