using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmYorum.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ImbdPuan = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FilmYili = table.Column<int>(type: "int", nullable: false),
                    TurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmSiniflari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurID = table.Column<int>(type: "int", nullable: false),
                    filmSinifiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSiniflari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmSiniflari_FilmSiniflari_filmSinifiId",
                        column: x => x.filmSinifiId,
                        principalTable: "FilmSiniflari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmSiniflari_filmSinifiId",
                table: "FilmSiniflari",
                column: "filmSinifiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "FilmSiniflari");
        }
    }
}
