using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig136 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "P_VaziatKhedmat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "P_VaziatKhedmat",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "P_VaziatKhedmat",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modifier",
                table: "P_VaziatKhedmat",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "P_ContactInf",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "P_ContactInf",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "P_ContactInf",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modifier",
                table: "P_ContactInf",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "P_BankAccountDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "P_BankAccountDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "P_BankAccountDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modifier",
                table: "P_BankAccountDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "P_VaziatKhedmat");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "P_VaziatKhedmat");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "P_VaziatKhedmat");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "P_VaziatKhedmat");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "P_ContactInf");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "P_ContactInf");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "P_ContactInf");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "P_ContactInf");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "P_BankAccountDetails");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "P_BankAccountDetails");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "P_BankAccountDetails");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "P_BankAccountDetails");
        }
    }
}
