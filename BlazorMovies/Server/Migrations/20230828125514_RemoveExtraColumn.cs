using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorMovies.Server.Migrations
{
    public partial class RemoveExtraColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres");

            migrationBuilder.DropColumn(
                name: "GenresId",
                table: "MoviesGenres");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres",
                columns: new[] { "MovieId", "GenreId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres");

            migrationBuilder.AddColumn<int>(
                name: "GenresId",
                table: "MoviesGenres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres",
                columns: new[] { "MovieId", "GenresId" });
        }
    }
}
