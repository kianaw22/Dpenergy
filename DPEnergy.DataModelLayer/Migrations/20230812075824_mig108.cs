using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig108 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BaravardHazine",
                table: "D_Project",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaravardHazine",
                table: "D_Project");
        }
    }
}
