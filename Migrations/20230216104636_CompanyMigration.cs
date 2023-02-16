using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantSystem.Company.Api.Migrations
{
    public partial class CompanyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "companies");

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "companies",
                columns: table => new
                {
                    CityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CountryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "companies",
                columns: table => new
                {
                    CountryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                schema: "companies",
                columns: table => new
                {
                    CurrencyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CurrencySymbol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.CurrencyID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "companies",
                columns: table => new
                {
                    LocationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "companies",
                columns: table => new
                {
                    CompanyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FaxNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CountryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VATNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VATRate = table.Column<double>(type: "float", nullable: false),
                    NHILRate = table.Column<double>(type: "float", nullable: false),
                    CurrencyID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityID",
                        column: x => x.CityID,
                        principalSchema: "companies",
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Countries_CountryID",
                        column: x => x.CountryID,
                        principalSchema: "companies",
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalSchema: "companies",
                        principalTable: "Currencies",
                        principalColumn: "CurrencyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Companies_Locations_LocationID",
                        column: x => x.LocationID,
                        principalSchema: "companies",
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityID",
                schema: "companies",
                table: "Companies",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CountryID",
                schema: "companies",
                table: "Companies",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CurrencyID",
                schema: "companies",
                table: "Companies",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_LocationID",
                schema: "companies",
                table: "Companies",
                column: "LocationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies",
                schema: "companies");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "companies");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "companies");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "companies");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "companies");
        }
    }
}
