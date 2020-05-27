using Microsoft.EntityFrameworkCore.Migrations;

namespace F1CRUD.Migrations
{
    public partial class Races : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    raceName = table.Column<string>(nullable: false),
                    circuitId = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    season = table.Column<int>(nullable: false),
                    round = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.raceName);
                    table.ForeignKey(
                        name: "FK_Races_Circuits_circuitId",
                        column: x => x.circuitId,
                        principalTable: "Circuits",
                        principalColumn: "circuitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Races_circuitId",
                table: "Races",
                column: "circuitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
