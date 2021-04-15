using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBack.Migrations
{
    public partial class AddPopularLocationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PopularLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 30, nullable: true),
                    Image = table.Column<string>(nullable: false),
                    CityName = table.Column<string>(maxLength: 50, nullable: false),
                    CityCount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopularLocations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PopularLocations");
        }
    }
}
