using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.DataAccess.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    StadiumName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoachsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfEstablishment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PresidentsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfLeagueTitles = table.Column<int>(type: "int", nullable: true),
                    NumberOfCupTitles = table.Column<int>(type: "int", nullable: true),
                    NumberOfChampionsLeagueTitles = table.Column<int>(type: "int", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubs_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Spain" },
                    { 2, "Germany" },
                    { 3, "England" },
                    { 4, "Turkey" },
                    { 5, "Italy" }
                });

            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "Id", "CoachsName", "CountryId", "DateOfEstablishment", "Logo", "Name", "NumberOfChampionsLeagueTitles", "NumberOfCupTitles", "NumberOfLeagueTitles", "PresidentsName", "StadiumName" },
                values: new object[,]
                {
                    { 1, "Xavi Hernandez", 1, null, null, "Barcelona", null, null, null, null, null },
                    { 2, "Carlo Ancelotti", 1, null, null, "Real Madrid", null, null, null, null, null },
                    { 5, "Jürgen Klopp", 3, null, null, "liverpool", null, null, null, null, null },
                    { 3, "Domènec Torrent", 4, null, null, "Galatasaray", null, null, null, null, null },
                    { 4, "Ersun Yanal", 4, null, null, "Fenerbahçe", null, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_CountryId",
                table: "Clubs",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
