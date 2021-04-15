using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBack.Migrations
{
    public partial class AddBlogSubscribeClientTestimonialsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    BlogImage = table.Column<string>(nullable: false),
                    BlogTittle = table.Column<string>(maxLength: 50, nullable: true),
                    BlogDescription = table.Column<string>(maxLength: 150, nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    PostedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientTestimonials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadTtitle = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 350, nullable: true),
                    WorkerImage = table.Column<string>(nullable: false),
                    WorkerName = table.Column<string>(maxLength: 70, nullable: true),
                    WorkerJob = table.Column<string>(maxLength: 70, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientTestimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subrices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subrices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "ClientTestimonials");

            migrationBuilder.DropTable(
                name: "Subrices");
        }
    }
}
