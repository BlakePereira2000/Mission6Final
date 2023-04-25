using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6Final.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "bill", false, "none", "none", "ten", "Lion King", 2000 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Nemo", false, "none", "none", "9", "Finding Nemo", 2000 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "MovieId", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Obi", false, "none", "none", "ten", "Star Wars", 2006 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");
        }
    }
}
