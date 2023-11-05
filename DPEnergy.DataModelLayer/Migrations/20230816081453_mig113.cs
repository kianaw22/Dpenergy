using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig113 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "D_UserProject",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "D_UserProject");
        }
    }
}
