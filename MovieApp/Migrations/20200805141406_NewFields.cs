using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movie");
        }
    }
}
