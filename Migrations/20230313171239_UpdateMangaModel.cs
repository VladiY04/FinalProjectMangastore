using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class UpdateMangaModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Manga",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Manga",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Manga");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Manga");
        }
    }
}
