using Microsoft.EntityFrameworkCore.Migrations;

namespace F1CRUD.Migrations
{
    public partial class Circuits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circuits",
                columns: table => new
                {
                    circuitId = table.Column<string>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    circuitName = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuits", x => x.circuitId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circuits");
        }
    }
}
