using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig154 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PBirthDate",
                table: "P_Personel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PStartWorkDate",
                table: "P_Personel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PBirthDate",
                table: "P_Personel");

            migrationBuilder.DropColumn(
                name: "PStartWorkDate",
                table: "P_Personel");
        }
    }
}
