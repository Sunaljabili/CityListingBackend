using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBack.Migrations
{
    public partial class BlogTableAddedCloumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BlogDescription",
                table: "BlogPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogNews",
                table: "BlogPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlogText",
                table: "BlogPosts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogDescription",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "BlogNews",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "BlogText",
                table: "BlogPosts");
        }
    }
}
