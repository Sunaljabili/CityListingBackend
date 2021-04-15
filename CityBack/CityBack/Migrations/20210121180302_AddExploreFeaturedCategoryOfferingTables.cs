using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBack.Migrations
{
    public partial class AddExploreFeaturedCategoryOfferingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Explores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 30, nullable: true),
                    Icon = table.Column<string>(nullable: false),
                    ChooseCategory = table.Column<string>(maxLength: 100, nullable: true),
                    CategoryTitle = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Explores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeaturedCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadTitle = table.Column<string>(maxLength: 80, nullable: true),
                    Title = table.Column<string>(maxLength: 80, nullable: true),
                    CatgIcon = table.Column<string>(nullable: false),
                    CatgTitle = table.Column<string>(maxLength: 100, nullable: false),
                    CatgDdescription = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturedCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offerings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Icon = table.Column<string>(nullable: false),
                    OfferingTitle = table.Column<string>(maxLength: 150, nullable: true),
                    OfferingDescription = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offerings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Explores");

            migrationBuilder.DropTable(
                name: "FeaturedCategories");

            migrationBuilder.DropTable(
                name: "Offerings");
        }
    }
}
