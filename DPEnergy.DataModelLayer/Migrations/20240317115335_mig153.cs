using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig153 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "P_ContactInf");

            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "P_ContactInf");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "P_ContactInf");

            migrationBuilder.CreateTable(
                name: "P_AccountType",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_AccountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_ContractType",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ContractType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_ContractType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_DocumentType",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    DocumentType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_DocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_EducationDegree",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    EducationDegree = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_EducationDegree", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_InstitutionName",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    InstitutionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_InstitutionName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_InsuranceStatus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    InsuranceStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_InsuranceStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MaritalStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_PersonelStatus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PersonelStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_PersonelStatus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "P_AccountType");

            migrationBuilder.DropTable(
                name: "P_ContractType");

            migrationBuilder.DropTable(
                name: "P_DocumentType");

            migrationBuilder.DropTable(
                name: "P_EducationDegree");

            migrationBuilder.DropTable(
                name: "P_InstitutionName");

            migrationBuilder.DropTable(
                name: "P_InsuranceStatus");

            migrationBuilder.DropTable(
                name: "P_MaritalStatus");

            migrationBuilder.DropTable(
                name: "P_PersonelStatus");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "P_ContactInf",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobilePhone",
                table: "P_ContactInf",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "P_ContactInf",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
