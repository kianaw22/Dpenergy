using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig142 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Active",
                table: "P_Takafol",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthdate",
                table: "P_Takafol",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "P_Takafol",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "P_Takafol",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModificationDate",
                table: "P_Takafol",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Modifier",
                table: "P_Takafol",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "P_Takafol",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "P_Takafol");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "P_Takafol");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "P_Takafol");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "P_Takafol");

            migrationBuilder.DropColumn(
                name: "ModificationDate",
                table: "P_Takafol");

            migrationBuilder.DropColumn(
                name: "Modifier",
                table: "P_Takafol");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "P_Takafol");
        }
    }
}
