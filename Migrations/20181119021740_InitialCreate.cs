using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HolidayChecklist.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TVShow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    First_Air_Date = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Overview = table.Column<string>(nullable: true),
                    Backdrop_Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVShow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    ParentShowID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SeasonNumber = table.Column<int>(nullable: false),
                    First_Air_Date = table.Column<DateTime>(nullable: false),
                    TVShowId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.ParentShowID);
                    table.ForeignKey(
                        name: "FK_Season_TVShow_TVShowId",
                        column: x => x.TVShowId,
                        principalTable: "TVShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    ParentShowID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParentSeasonNumber = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Overview = table.Column<string>(nullable: true),
                    First_Air_Date = table.Column<DateTime>(nullable: false),
                    SeasonParentShowID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.ParentShowID);
                    table.ForeignKey(
                        name: "FK_Episode_Season_SeasonParentShowID",
                        column: x => x.SeasonParentShowID,
                        principalTable: "Season",
                        principalColumn: "ParentShowID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episode_SeasonParentShowID",
                table: "Episode",
                column: "SeasonParentShowID");

            migrationBuilder.CreateIndex(
                name: "IX_Season_TVShowId",
                table: "Season",
                column: "TVShowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episode");

            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropTable(
                name: "TVShow");
        }
    }
}
