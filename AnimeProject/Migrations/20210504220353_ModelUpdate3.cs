using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeProject.Migrations
{
    public partial class ModelUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureURL",
                table: "Animes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureURL",
                table: "Animes");
        }
    }
}
