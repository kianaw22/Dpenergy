using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig135 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "P_Personel",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "P_BankAccountDetails",
                columns: table => new
                {
                    PersonelCode = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BankAccountNumber = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    Accounttype = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_BankAccountDetails", x => x.PersonelCode);
                });

            migrationBuilder.CreateTable(
                name: "P_ContactInf",
                columns: table => new
                {
                    PersonelCode = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PropertyType = table.Column<string>(nullable: true),
                    IntroducedName = table.Column<string>(nullable: true),
                    IntroducedPhone = table.Column<string>(nullable: true),
                    IntroducedAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ContactInf", x => x.PersonelCode);
                });

            migrationBuilder.CreateTable(
                name: "P_VaziatKhedmat",
                columns: table => new
                {
                    PersonelCode = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    VaziatNezamVazife = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    OrganName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_VaziatKhedmat", x => x.PersonelCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "P_BankAccountDetails");

            migrationBuilder.DropTable(
                name: "P_ContactInf");

            migrationBuilder.DropTable(
                name: "P_VaziatKhedmat");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "P_Personel");
        }
    }
}
