using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adults",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JobTitle = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    firstName = table.Column<string>(type: "TEXT", nullable: false),
                    lastName = table.Column<string>(type: "TEXT", nullable: true),
                    hairColor = table.Column<string>(type: "TEXT", nullable: true),
                    eyeColor = table.Column<string>(type: "TEXT", nullable: true),
                    age = table.Column<int>(type: "INTEGER", nullable: false),
                    weight = table.Column<float>(type: "REAL", nullable: false),
                    height = table.Column<int>(type: "INTEGER", nullable: false),
                    sex = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adults", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adults");
        }
    }
}
