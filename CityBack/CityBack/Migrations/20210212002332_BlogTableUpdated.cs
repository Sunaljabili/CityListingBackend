using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBack.Migrations
{
    public partial class BlogTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "CommentIcon",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "Travel",
                table: "BlogPosts");

            migrationBuilder.DropColumn(
                name: "TravelIcon",
                table: "BlogPosts");

            migrationBuilder.RenameColumn(
                name: "dateTime",
                table: "BlogPosts",
                newName: "DateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "BlogPosts",
                newName: "dateTime");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommentIcon",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Travel",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TravelIcon",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
