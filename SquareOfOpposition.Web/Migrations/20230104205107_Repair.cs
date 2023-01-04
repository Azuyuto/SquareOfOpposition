using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SquareOfOpposition.Web.Migrations
{
    /// <inheritdoc />
    public partial class Repair : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SentanceI",
                table: "Squares",
                newName: "SentenceO");

            migrationBuilder.RenameColumn(
                name: "SentanceE",
                table: "Squares",
                newName: "SentenceI");

            migrationBuilder.RenameColumn(
                name: "SentanceA",
                table: "Squares",
                newName: "SentenceE");

            migrationBuilder.RenameColumn(
                name: "SenranceO",
                table: "Squares",
                newName: "SentenceA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SentenceO",
                table: "Squares",
                newName: "SentanceI");

            migrationBuilder.RenameColumn(
                name: "SentenceI",
                table: "Squares",
                newName: "SentanceE");

            migrationBuilder.RenameColumn(
                name: "SentenceE",
                table: "Squares",
                newName: "SentanceA");

            migrationBuilder.RenameColumn(
                name: "SentenceA",
                table: "Squares",
                newName: "SenranceO");
        }
    }
}
