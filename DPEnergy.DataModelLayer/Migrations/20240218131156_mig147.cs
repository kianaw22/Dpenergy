using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig147 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "P_Bime",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PersonelCode = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    VaziatBime = table.Column<string>(nullable: true),
                    BimeNumber = table.Column<string>(nullable: true),
                    SabegheTaminEjtemaei = table.Column<int>(nullable: false),
                    TarikhSabtSabegheTamin = table.Column<DateTime>(nullable: false),
                    SabegheKhodEzhari = table.Column<int>(nullable: false),
                    TarikhSabtKhodEzhari = table.Column<DateTime>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    Modifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_Bime", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "P_Bime");
        }
    }
}
