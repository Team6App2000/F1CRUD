using Microsoft.EntityFrameworkCore.Migrations;

namespace F1CRUD.Migrations
{
    public partial class Const : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Constructors",
                columns: table => new
                {
                    constructorsId = table.Column<string>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    nationality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constructors", x => x.constructorsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constructors");
        }
    }
}
