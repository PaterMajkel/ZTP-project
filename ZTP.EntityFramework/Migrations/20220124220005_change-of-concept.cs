using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZTP.EntityFramework.Migrations
{
    public partial class changeofconcept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LvlNumber",
                table: "Levels",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Levels",
                newName: "LvlNumber");
        }
    }
}
