using Microsoft.EntityFrameworkCore.Migrations;

namespace RYAN_sport.Migrations.SportDB
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    ContentAbout = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "exercisePackages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    TitlePackage = table.Column<string>(nullable: true),
                    ContentPackage = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    datePackage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercisePackages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "galerys",
                columns: table => new
                {
                    GaleryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    SportName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_galerys", x => x.GaleryID);
                });

            migrationBuilder.CreateTable(
                name: "HeaderImages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    SportName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderImages", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "exercisePackages");

            migrationBuilder.DropTable(
                name: "galerys");

            migrationBuilder.DropTable(
                name: "HeaderImages");
        }
    }
}
