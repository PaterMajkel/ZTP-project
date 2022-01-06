using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZTP.EntityFramework.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LvlNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LvlAssets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LvlEnemies = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LvlNumber);
                });

            migrationBuilder.CreateTable(
                name: "ScoreBoards",
                columns: table => new
                {
                    ScoreBoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LevelNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreBoards", x => x.ScoreBoardId);
                    table.ForeignKey(
                        name: "FK_ScoreBoards_Levels_LevelNumber",
                        column: x => x.LevelNumber,
                        principalTable: "Levels",
                        principalColumn: "LvlNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScoreBoards_LevelNumber",
                table: "ScoreBoards",
                column: "LevelNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreBoards");

            migrationBuilder.DropTable(
                name: "Levels");
        }
    }
}
