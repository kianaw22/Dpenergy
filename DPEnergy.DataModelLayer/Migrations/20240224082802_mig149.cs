using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig149 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "P_Courses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PersonelCode = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Madrak = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: true),
                    InstitueName = table.Column<string>(nullable: true),
                    Attachment = table.Column<string>(nullable: true),
                    Counter = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    Modifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_LetterRequest",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PersonelCode = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Reciever = table.Column<string>(nullable: true),
                    IssueDate = table.Column<DateTime>(nullable: true),
                    Attachment = table.Column<string>(nullable: true),
                    Counter = table.Column<int>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    Modifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_LetterRequest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "P_MadrakTahsili",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PersonelCode = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MadrakTahsili = table.Column<string>(nullable: true),
                    MadrakType = table.Column<string>(nullable: true),
                    FieldOfStudy = table.Column<string>(nullable: true),
                    GraduationYear = table.Column<DateTime>(nullable: true),
                    Obligation = table.Column<bool>(nullable: false),
                    Confirmation = table.Column<bool>(nullable: false),
                    Attachment = table.Column<string>(nullable: true),
                    Counter = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    Creator = table.Column<string>(nullable: true),
                    Modifier = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_P_MadrakTahsili", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "P_Courses");

            migrationBuilder.DropTable(
                name: "P_LetterRequest");

            migrationBuilder.DropTable(
                name: "P_MadrakTahsili");
        }
    }
}
