using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig99 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_MDR");

            migrationBuilder.DropTable(
                name: "D_Revision");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_MDR",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Active = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bidover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientDicipline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomField2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomField3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomField4 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomField5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DaryapalaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DpDicipline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FirstIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MHR = table.Column<float>(type: "real", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_MDR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Revision",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CD = table.Column<bool>(type: "bit", nullable: false),
                    CheckList = table.Column<bool>(type: "bit", nullable: false),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientDicipline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentsheetNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentsheetStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commentsheetdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consultant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Creator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomField1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomField2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomField4 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomFiled3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DpDicipline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DpNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<bool>(type: "bit", nullable: false),
                    File = table.Column<bool>(type: "bit", nullable: false),
                    IncomingTransmittalCheck = table.Column<bool>(type: "bit", nullable: false),
                    IssuedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingHeld = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Modifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofCopies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Original = table.Column<bool>(type: "bit", nullable: false),
                    Other = table.Column<bool>(type: "bit", nullable: false),
                    Page = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreparedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Print = table.Column<bool>(type: "bit", nullable: false),
                    Progress = table.Column<float>(type: "real", nullable: false),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reciever = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedMOMDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RelatedMOMNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemarksTransmittal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepltysheetNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplysheetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReplysheetStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnedRepltysheetNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReturnedReplysheetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnedReplysheetStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Revision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransmittalCreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransmittalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransmittalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Revision", x => x.Id);
                });
        }
    }
}
