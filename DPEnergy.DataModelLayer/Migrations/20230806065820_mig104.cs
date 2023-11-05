using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig104 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_RevisionCode");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "D_Revision",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "D_Revision",
                newName: "ID");

            migrationBuilder.CreateTable(
                name: "D_RevisionCode",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Creator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevisionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RevisionCode", x => x.Id);
                });
        }
    }
}
