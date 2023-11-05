using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_RetReplysheetStage",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProjectCode = table.Column<string>(nullable: true),
                    Stage = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Modifier = table.Column<string>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_RetReplysheetStage", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
