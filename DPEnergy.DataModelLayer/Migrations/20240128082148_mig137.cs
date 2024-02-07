using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig137 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_P_VaziatKhedmat",
                table: "P_VaziatKhedmat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_P_ContactInf",
                table: "P_ContactInf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_P_BankAccountDetails",
                table: "P_BankAccountDetails");

            migrationBuilder.AlterColumn<string>(
                name: "PersonelCode",
                table: "P_VaziatKhedmat",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "P_VaziatKhedmat",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PersonelCode",
                table: "P_ContactInf",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "P_ContactInf",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PersonelCode",
                table: "P_BankAccountDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "P_BankAccountDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_VaziatKhedmat",
                table: "P_VaziatKhedmat",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_ContactInf",
                table: "P_ContactInf",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_BankAccountDetails",
                table: "P_BankAccountDetails",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_P_VaziatKhedmat",
                table: "P_VaziatKhedmat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_P_ContactInf",
                table: "P_ContactInf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_P_BankAccountDetails",
                table: "P_BankAccountDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "P_VaziatKhedmat");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "P_ContactInf");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "P_BankAccountDetails");

            migrationBuilder.AlterColumn<string>(
                name: "PersonelCode",
                table: "P_VaziatKhedmat",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonelCode",
                table: "P_ContactInf",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonelCode",
                table: "P_BankAccountDetails",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_VaziatKhedmat",
                table: "P_VaziatKhedmat",
                column: "PersonelCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_ContactInf",
                table: "P_ContactInf",
                column: "PersonelCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_BankAccountDetails",
                table: "P_BankAccountDetails",
                column: "PersonelCode");
        }
    }
}
