using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig98 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ReportName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProjectCode = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    ReportPath = table.Column<string>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Modifier = table.Column<string>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
