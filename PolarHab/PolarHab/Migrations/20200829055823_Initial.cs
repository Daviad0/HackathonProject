using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PolarHab.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionKey = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuestionName = table.Column<string>(nullable: true),
                    QuestionDescription = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true),
                    Wrong1Dialogue = table.Column<string>(nullable: true),
                    Wrong2Dialogue = table.Column<string>(nullable: true),
                    Wrong3Dialogue = table.Column<string>(nullable: true),
                    CorrectDialogue = table.Column<string>(nullable: true),
                    CorrectWhyTitle = table.Column<string>(nullable: true),
                    CorrectWhyDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionKey);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
