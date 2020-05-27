using Microsoft.EntityFrameworkCore.Migrations;

namespace F1CRUD.Migrations
{
    public partial class Results : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    resultId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    constructorId = table.Column<string>(nullable: true),
                    raceName = table.Column<string>(nullable: true),
                    circuitId = table.Column<string>(nullable: true),
                    driverId = table.Column<string>(nullable: true),
                    number = table.Column<int>(nullable: false),
                    position = table.Column<int>(nullable: false),
                    points = table.Column<int>(nullable: false),
                    grid = table.Column<int>(nullable: false),
                    laps = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.resultId);
                    table.ForeignKey(
                        name: "FK_Results_Circuits_circuitId",
                        column: x => x.circuitId,
                        principalTable: "Circuits",
                        principalColumn: "circuitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_Constructors_constructorId",
                        column: x => x.constructorId,
                        principalTable: "Constructors",
                        principalColumn: "constructorsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_Drivers_driverId",
                        column: x => x.driverId,
                        principalTable: "Drivers",
                        principalColumn: "driverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Results_Races_raceName",
                        column: x => x.raceName,
                        principalTable: "Races",
                        principalColumn: "raceName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_circuitId",
                table: "Results",
                column: "circuitId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_constructorId",
                table: "Results",
                column: "constructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_driverId",
                table: "Results",
                column: "driverId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_raceName",
                table: "Results",
                column: "raceName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
