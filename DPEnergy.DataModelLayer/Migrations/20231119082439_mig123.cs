using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomFiled3",
                table: "D_Revision");

            migrationBuilder.AddColumn<string>(
                name: "CustomField3",
                table: "D_Revision",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomField3",
                table: "D_Revision");

            migrationBuilder.AddColumn<string>(
                name: "CustomFiled3",
                table: "D_Revision",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
