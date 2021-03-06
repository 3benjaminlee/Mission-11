using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Migrations
{
    public partial class AddBuysTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
        name: "Buys",
        columns: table => new
        {
            BuyId = table.Column<int>(nullable: false)
                .Annotation("Sqlite:Autoincrement", true),
            Name = table.Column<string>(nullable: false),
            AddressLine1 = table.Column<string>(nullable: false),
            AddressLine2 = table.Column<string>(nullable: true),
            AddressLine3 = table.Column<string>(nullable: true),
            city = table.Column<string>(nullable: false),
            State = table.Column<string>(nullable: false),
            Zip = table.Column<string>(nullable: true),
            Country = table.Column<string>(nullable: false)
        },
        constraints: table =>
        {
            table.PrimaryKey("PK_Buys", x => x.BuyId);
        });

            migrationBuilder.CreateTable(
                name: "BasketLineItem",
                columns: table => new
                {
                    LineID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    BuyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketLineItem", x => x.LineID);
                    table.ForeignKey(
                        name: "FK_BasketLineItem_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasketLineItem_Buys_BuyId",
                        column: x => x.BuyId,
                        principalTable: "Buys",
                        principalColumn: "BuyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_BookID",
                table: "BasketLineItem",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_BuyId",
                table: "BasketLineItem",
                column: "BuyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketLineItem");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Buys");
        }
    }
}
