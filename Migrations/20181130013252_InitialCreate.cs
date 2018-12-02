using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayChecklist.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    EpisodeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShowID = table.Column<int>(nullable: false),
                    SeasonNumber = table.Column<int>(nullable: false),
                    ShowTitle = table.Column<string>(nullable: true),
                    ShowBackdropPath = table.Column<string>(nullable: true),
                    ShowOverview = table.Column<string>(nullable: true),
                    EpisodeAirDate = table.Column<DateTime>(nullable: false),
                    EpisodeNumber = table.Column<int>(nullable: false),
                    EpisodeTitle = table.Column<string>(nullable: true),
                    EpisodeOverview = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.EpisodeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episode");
        }
    }
}
