using Microsoft.EntityFrameworkCore.Migrations;

namespace PolarHab.Migrations
{
    public partial class QuestionModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer1ModelJson",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer2ModelJson",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer3ModelJson",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer4ModelJson",
                table: "Questions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer1ModelJson",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Answer2ModelJson",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Answer3ModelJson",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Answer4ModelJson",
                table: "Questions");
        }
    }
}
