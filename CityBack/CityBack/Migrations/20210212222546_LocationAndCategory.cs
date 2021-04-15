using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBack.Migrations
{
    public partial class LocationAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeaturedCategoryId",
                table: "PopularLocations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CatgIcon",
                table: "FeaturedCategories",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_PopularLocations_FeaturedCategoryId",
                table: "PopularLocations",
                column: "FeaturedCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PopularLocations_FeaturedCategories_FeaturedCategoryId",
                table: "PopularLocations",
                column: "FeaturedCategoryId",
                principalTable: "FeaturedCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PopularLocations_FeaturedCategories_FeaturedCategoryId",
                table: "PopularLocations");

            migrationBuilder.DropIndex(
                name: "IX_PopularLocations_FeaturedCategoryId",
                table: "PopularLocations");

            migrationBuilder.DropColumn(
                name: "FeaturedCategoryId",
                table: "PopularLocations");

            migrationBuilder.AlterColumn<string>(
                name: "CatgIcon",
                table: "FeaturedCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
