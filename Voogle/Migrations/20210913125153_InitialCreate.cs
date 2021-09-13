using Microsoft.EntityFrameworkCore.Migrations;

namespace Voogle.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Upvotes",
                table: "Request");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Upvotes",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
