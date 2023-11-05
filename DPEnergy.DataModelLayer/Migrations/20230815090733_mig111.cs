using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectCoce",
                table: "D_UserProject");

            migrationBuilder.DropColumn(
                name: "ProjectTitle",
                table: "D_UserProject");

            migrationBuilder.AddColumn<string>(
                name: "ProjectCode",
                table: "D_UserProject",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectCode",
                table: "D_UserProject");

            migrationBuilder.AddColumn<string>(
                name: "ProjectCoce",
                table: "D_UserProject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectTitle",
                table: "D_UserProject",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
