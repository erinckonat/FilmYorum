using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmYorum.Migrations
{
    /// <inheritdoc />
    public partial class FilmSiniflari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmSinifs_FilmSinifs_filmSinifiId",
                table: "FilmSinifs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmSinifs",
                table: "FilmSinifs");

            migrationBuilder.RenameTable(
                name: "FilmSinifs",
                newName: "FilmSiniflari");

            migrationBuilder.RenameIndex(
                name: "IX_FilmSinifs_filmSinifiId",
                table: "FilmSiniflari",
                newName: "IX_FilmSiniflari_filmSinifiId");

            migrationBuilder.AlterColumn<int>(
                name: "TurID",
                table: "FilmSiniflari",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "TurAd",
                table: "FilmSiniflari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmSiniflari",
                table: "FilmSiniflari",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmSiniflari_FilmSiniflari_filmSinifiId",
                table: "FilmSiniflari",
                column: "filmSinifiId",
                principalTable: "FilmSiniflari",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmSiniflari_FilmSiniflari_filmSinifiId",
                table: "FilmSiniflari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmSiniflari",
                table: "FilmSiniflari");

            migrationBuilder.DropColumn(
                name: "TurAd",
                table: "FilmSiniflari");

            migrationBuilder.RenameTable(
                name: "FilmSiniflari",
                newName: "FilmSinifs");

            migrationBuilder.RenameIndex(
                name: "IX_FilmSiniflari_filmSinifiId",
                table: "FilmSinifs",
                newName: "IX_FilmSinifs_filmSinifiId");

            migrationBuilder.AlterColumn<int>(
                name: "TurID",
                table: "FilmSinifs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmSinifs",
                table: "FilmSinifs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmSinifs_FilmSinifs_filmSinifiId",
                table: "FilmSinifs",
                column: "filmSinifiId",
                principalTable: "FilmSinifs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
