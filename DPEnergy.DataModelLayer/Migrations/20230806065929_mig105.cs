using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig105 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_RevisionCode",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProjectCode = table.Column<string>(nullable: true),
                    RevisionName = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Modifier = table.Column<string>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RevisionCode", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_RevisionCode");
        }
    }
}
