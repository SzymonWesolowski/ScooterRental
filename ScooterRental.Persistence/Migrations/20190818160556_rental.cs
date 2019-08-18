using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScooterRental.Persistence.Migrations
{
    public partial class rental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    DefectId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: true),
                    ScooterId = table.Column<int>(nullable: false),
                    DefectDescription = table.Column<string>(nullable: true),
                    Resolved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.DefectId);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalId = table.Column<string>(nullable: false),
                    ScooterId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    RentalStart = table.Column<DateTime>(nullable: false),
                    RentalEnd = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalId);
                });

            migrationBuilder.CreateTable(
                name: "Scooters",
                columns: table => new
                {
                    ScooterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rented = table.Column<bool>(nullable: false),
                    Defected = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scooters", x => x.ScooterId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Scooters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
