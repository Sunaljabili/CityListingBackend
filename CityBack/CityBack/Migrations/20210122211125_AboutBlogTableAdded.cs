using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBack.Migrations
{
    public partial class AboutBlogTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Subrices",
                table: "Subrices");

            migrationBuilder.RenameTable(
                name: "Subrices",
                newName: "Subscribe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscribe",
                table: "Subscribe",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AboutCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(nullable: true),
                    AboutDescription = table.Column<string>(nullable: true),
                    MissionTitle = table.Column<string>(nullable: true),
                    MissionDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true),
                    CategoryCount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogInstagramFeeds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogInstagramFeeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    PostTitle = table.Column<string>(nullable: true),
                    PostDescription = table.Column<string>(nullable: true),
                    dateTime = table.Column<DateTime>(nullable: false),
                    BlogDetailLink = table.Column<string>(nullable: true),
                    CommentIcon = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    Travel = table.Column<string>(nullable: true),
                    TravelIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogRecents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    RecentTitle = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogRecents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    CloudsLinks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutCompanies");

            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "BlogInstagramFeeds");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "BlogRecents");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscribe",
                table: "Subscribe");

            migrationBuilder.RenameTable(
                name: "Subscribe",
                newName: "Subrices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subrices",
                table: "Subrices",
                column: "Id");
        }
    }
}
