using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SquareOfOpposition.Web.Migrations
{
    /// <inheritdoc />
    public partial class Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_States_StateId",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_States_StateId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "States");

            migrationBuilder.CreateTable(
                name: "StateSet",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false),
                    DestinationStateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateSet", x => new { x.DestinationStateId, x.StateId });
                    table.ForeignKey(
                        name: "FK_StateSet_States_DestinationStateId",
                        column: x => x.DestinationStateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StateSet_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StateSet_StateId",
                table: "StateSet",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StateSet");

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "States",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_States_StateId",
                table: "States",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_States_States_StateId",
                table: "States",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id");
        }
    }
}
