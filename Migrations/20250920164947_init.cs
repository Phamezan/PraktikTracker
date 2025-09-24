using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PraktikTracker.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentViaWebsite = table.Column<bool>(type: "bit", nullable: false),
                    HasSentApplication = table.Column<bool>(type: "bit", nullable: false),
                    EmailSent = table.Column<DateOnly>(type: "date", nullable: true),
                    FollowUpDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Answer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Answer", "Description", "EmailSent", "FollowUpDate", "HasSentApplication", "Name", "SentViaWebsite", "URL" },
                values: new object[,]
                {
                    { 1, 0, "", new DateOnly(2025, 6, 23), new DateOnly(2025, 10, 4), true, "Hesehus", true, "https://www.hesehus.dk/karriere/praktik-og-studieprojekt" },
                    { 2, 0, "", new DateOnly(2025, 6, 23), new DateOnly(2025, 10, 4), true, "Vitec", true, "https://jobs.vitecsoftware.dk/jobs/1208909-praktikperiode-hos-vitec-software-group" },
                    { 3, 0, "Arbejder i mange sprog og frameworks som f.eks. C# og React", new DateOnly(2025, 6, 23), new DateOnly(2025, 10, 4), true, "Viking", false, "https://www.vikingsoftware.com/get-in-touch/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
