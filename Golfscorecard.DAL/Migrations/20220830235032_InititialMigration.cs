using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Golfscorecard.DAL.Migrations
{
    public partial class InititialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scorecards",
                columns: table => new
                {
                    ScorecardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoleNumber = table.Column<int>(type: "int", nullable: false),
                    PlayerOne = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PlayerTwo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PlayerThree = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PlayerFour = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scorecards", x => x.ScorecardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scorecards");
        }
    }
}
