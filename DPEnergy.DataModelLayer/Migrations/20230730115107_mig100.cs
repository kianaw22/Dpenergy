using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPEnergy.DataModelLayer.Migrations
{
    public partial class mig100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "D_MDR",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProjectCode = table.Column<string>(nullable: true),
                    ClientNumber = table.Column<string>(nullable: true),
                    DocumentTitle = table.Column<string>(nullable: true),
                    DaryapalaNumber = table.Column<string>(nullable: true),
                    WF = table.Column<string>(nullable: true),
                    DpDicipline = table.Column<string>(nullable: true),
                    Unit = table.Column<string>(nullable: true),
                    Phase = table.Column<string>(nullable: true),
                    DocumentType = table.Column<string>(nullable: true),
                    Bidover = table.Column<string>(nullable: true),
                    ClientDicipline = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
                    AdditionalWork = table.Column<string>(nullable: true),
                    FirstIssueDate = table.Column<DateTime>(nullable: true),
                    SecondIssueDate = table.Column<DateTime>(nullable: true),
                    FinalIssueDate = table.Column<DateTime>(nullable: true),
                    CustomField1 = table.Column<string>(nullable: true),
                    CustomField2 = table.Column<string>(nullable: true),
                    CustomField3 = table.Column<DateTime>(nullable: true),
                    CustomField4 = table.Column<DateTime>(nullable: true),
                    CustomField5 = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Section = table.Column<string>(nullable: true),
                    MHR = table.Column<float>(nullable: false),
                    Creator = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Modifier = table.Column<string>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_MDR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Revision",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProjectCode = table.Column<string>(nullable: true),
                    TransmittalNumber = table.Column<string>(nullable: true),
                    DpNumber = table.Column<string>(nullable: true),
                    DocumentTitle = table.Column<string>(nullable: true),
                    ClientNumber = table.Column<string>(nullable: true),
                    Revision = table.Column<string>(nullable: true),
                    StageName = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
                    CommentsheetNo = table.Column<string>(nullable: true),
                    Commentsheetdate = table.Column<DateTime>(nullable: true),
                    CommentsheetStatus = table.Column<string>(nullable: true),
                    RepltysheetNo = table.Column<string>(nullable: true),
                    ReplysheetDate = table.Column<DateTime>(nullable: true),
                    ReplysheetStatus = table.Column<string>(nullable: true),
                    ReturnedRepltysheetNo = table.Column<string>(nullable: true),
                    ReturnedReplysheetDate = table.Column<DateTime>(nullable: true),
                    ReturnedReplysheetStatus = table.Column<string>(nullable: true),
                    RelatedMOMNo = table.Column<string>(nullable: true),
                    RelatedMOMDate = table.Column<DateTime>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Progress = table.Column<float>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    TransmittalDate = table.Column<DateTime>(nullable: true),
                    TransmittalCreatedBy = table.Column<string>(nullable: true),
                    Page = table.Column<string>(nullable: true),
                    IssuedBy = table.Column<string>(nullable: true),
                    Reciever = table.Column<string>(nullable: true),
                    RemarksTransmittal = table.Column<string>(nullable: true),
                    NumberofCopies = table.Column<string>(nullable: true),
                    Consultant = table.Column<string>(nullable: true),
                    Client = table.Column<string>(nullable: true),
                    SentType = table.Column<string>(nullable: true),
                    CustomField1 = table.Column<string>(nullable: true),
                    CustomField2 = table.Column<string>(nullable: true),
                    CustomFiled3 = table.Column<string>(nullable: true),
                    CustomField4 = table.Column<DateTime>(nullable: true),
                    PreparedBy = table.Column<string>(nullable: true),
                    MeetingHeld = table.Column<string>(nullable: true),
                    DpDicipline = table.Column<string>(nullable: true),
                    ClientDicipline = table.Column<string>(nullable: true),
                    CheckList = table.Column<bool>(nullable: false),
                    IncomingTransmittalCheck = table.Column<bool>(nullable: false),
                    Creator = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    Modifier = table.Column<string>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    CD = table.Column<bool>(nullable: false),
                    Print = table.Column<bool>(nullable: false),
                    Email = table.Column<bool>(nullable: false),
                    Other = table.Column<bool>(nullable: false),
                    Original = table.Column<bool>(nullable: false),
                    File = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Revision", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "D_MDR");

            migrationBuilder.DropTable(
                name: "D_Revision");
        }
    }
}
