using Microsoft.EntityFrameworkCore.Migrations;

namespace PolarHab.Migrations
{
    public partial class CookieTag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CookieTag",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookieTag",
                table: "Questions");
        }
    }
}
