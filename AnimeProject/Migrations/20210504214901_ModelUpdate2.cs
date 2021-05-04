using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeProject.Migrations
{
    public partial class ModelUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "AiringDay",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AiringDay",
                table: "Animes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
