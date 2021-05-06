using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeProject.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animes_Months_MonthID",
                table: "Animes");

            migrationBuilder.AlterColumn<int>(
                name: "MonthID",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animes_Months_MonthID",
                table: "Animes",
                column: "MonthID",
                principalTable: "Months",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animes_Months_MonthID",
                table: "Animes");

            migrationBuilder.AlterColumn<int>(
                name: "MonthID",
                table: "Animes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Animes_Months_MonthID",
                table: "Animes",
                column: "MonthID",
                principalTable: "Months",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
