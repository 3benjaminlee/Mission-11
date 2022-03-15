using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Migrations
{
    public partial class AddReceivedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "city",
                table: "Buys",
                newName: "City");

            migrationBuilder.AddColumn<bool>(
                name: "BuyReceived",
                table: "Buys",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyReceived",
                table: "Buys");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Buys",
                newName: "city");
        }
    }
}
