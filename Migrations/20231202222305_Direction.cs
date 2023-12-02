using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Direction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DirectionId",
                table: "States",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Directions",
                columns: table => new
                {
                    DirectionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directions", x => x.DirectionId);
                });

            migrationBuilder.InsertData(
                table: "Directions",
                columns: new[] { "DirectionId", "Name" },
                values: new object[,]
                {
                    { "Ea", "East" },
                    { "Ne", "NorthEast" },
                    { "No", "North" },
                    { "Nw", "NorthWest" },
                    { "Se", "SouthEast" },
                    { "So", "South" },
                    { "Sw", "SouthWest" },
                    { "We", "West" }
                });

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                column: "DirectionId",
                value: "No");

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2,
                column: "DirectionId",
                value: "No");

            migrationBuilder.CreateIndex(
                name: "IX_States_DirectionId",
                table: "States",
                column: "DirectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Directions_DirectionId",
                table: "States",
                column: "DirectionId",
                principalTable: "Directions",
                principalColumn: "DirectionId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_Directions_DirectionId",
                table: "States");

            migrationBuilder.DropTable(
                name: "Directions");

            migrationBuilder.DropIndex(
                name: "IX_States_DirectionId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "DirectionId",
                table: "States");
        }
    }
}
