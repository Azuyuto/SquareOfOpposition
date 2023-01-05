using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SquareOfOpposition.Web.Migrations
{
    /// <inheritdoc />
    public partial class Dest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateTransitions_States_DestinationStateId",
                table: "StateTransitions");

            migrationBuilder.AddForeignKey(
                name: "FK_StateTransitions_States_DestinationStateId",
                table: "StateTransitions",
                column: "DestinationStateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateTransitions_States_DestinationStateId",
                table: "StateTransitions");

            migrationBuilder.AddForeignKey(
                name: "FK_StateTransitions_States_DestinationStateId",
                table: "StateTransitions",
                column: "DestinationStateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
