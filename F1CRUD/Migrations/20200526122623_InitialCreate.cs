using Microsoft.EntityFrameworkCore.Migrations;

namespace F1CRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    driverId = table.Column<string>(nullable: false),
                    url = table.Column<string>(nullable: true),
                    givenName = table.Column<string>(nullable: true),
                    familyName = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<string>(nullable: true),
                    nationality = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.driverId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
