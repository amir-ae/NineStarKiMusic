using Microsoft.EntityFrameworkCore.Migrations;

namespace NineStarKi.Migrations
{
    public partial class Genres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Musicians_MusicianId",
                table: "Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Occasion_Musicians_MusicianId",
                table: "Occasion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occasion",
                table: "Occasion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "Occasion",
                newName: "Occasions");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameIndex(
                name: "IX_Occasion_MusicianId",
                table: "Occasions",
                newName: "IX_Occasions_MusicianId");

            migrationBuilder.RenameIndex(
                name: "IX_Genre_MusicianId",
                table: "Genres",
                newName: "IX_Genres_MusicianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occasions",
                table: "Occasions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Musicians_MusicianId",
                table: "Genres",
                column: "MusicianId",
                principalTable: "Musicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Occasions_Musicians_MusicianId",
                table: "Occasions",
                column: "MusicianId",
                principalTable: "Musicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Musicians_MusicianId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Occasions_Musicians_MusicianId",
                table: "Occasions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occasions",
                table: "Occasions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Occasions",
                newName: "Occasion");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameIndex(
                name: "IX_Occasions_MusicianId",
                table: "Occasion",
                newName: "IX_Occasion_MusicianId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_MusicianId",
                table: "Genre",
                newName: "IX_Genre_MusicianId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occasion",
                table: "Occasion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Musicians_MusicianId",
                table: "Genre",
                column: "MusicianId",
                principalTable: "Musicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Occasion_Musicians_MusicianId",
                table: "Occasion",
                column: "MusicianId",
                principalTable: "Musicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
