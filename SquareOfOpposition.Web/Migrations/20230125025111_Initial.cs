using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SquareOfOpposition.Web.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Squares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentStateId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentenceO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squares", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SquareId = table.Column<int>(type: "int", nullable: false),
                    StateTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Squares_SquareId",
                        column: x => x.SquareId,
                        principalTable: "Squares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateTransitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickupStateId = table.Column<int>(type: "int", nullable: false),
                    DestinationStateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateTransitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StateTransitions_States_DestinationStateId",
                        column: x => x.DestinationStateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateTransitions_States_PickupStateId",
                        column: x => x.PickupStateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Squares_ParentStateId",
                table: "Squares",
                column: "ParentStateId");

            migrationBuilder.CreateIndex(
                name: "IX_States_SquareId",
                table: "States",
                column: "SquareId");

            migrationBuilder.CreateIndex(
                name: "IX_StateTransitions_DestinationStateId",
                table: "StateTransitions",
                column: "DestinationStateId");

            migrationBuilder.CreateIndex(
                name: "IX_StateTransitions_PickupStateId",
                table: "StateTransitions",
                column: "PickupStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Squares_States_ParentStateId",
                table: "Squares",
                column: "ParentStateId",
                principalTable: "States",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squares_States_ParentStateId",
                table: "Squares");

            migrationBuilder.DropTable(
                name: "StateTransitions");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Squares");
        }
    }
}
