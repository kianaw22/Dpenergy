using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig152 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_P_Courses",
                table: "P_Courses");

            migrationBuilder.RenameTable(
                name: "P_Courses",
                newName: "P_Course");

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_Course",
                table: "P_Course",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_P_Course",
                table: "P_Course");

            migrationBuilder.RenameTable(
                name: "P_Course",
                newName: "P_Courses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_P_Courses",
                table: "P_Courses",
                column: "Id");
        }
    }
}
