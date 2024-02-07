using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Entities.DMS.Stackholders;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Entities.Reporrts;
using DPEnergy.DataModelLayer.Entities.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer
{
    public class ApplicationDbContext : IdentityDbContext<A_UserManager, ApplicationRoles,string >
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {

        }
        public DbSet<P_Personel> P_Personel{ get; set; }
        public DbSet<P_City> P_City { get; set; }
        public DbSet<P_Department> P_Department { get; set; }
        public DbSet<P_Company> P_Company { get; set; }
        public DbSet<P_MahalKhedmat> P_MahalKhedmat { get; set; }
        public DbSet<P_Post> P_Post { get; set; }
        public DbSet<P_WorkPlace> P_WorkPlace { get; set; }
        public DbSet<D_Project> D_Project { get; set; }
        public DbSet<D_ProjectType> D_ProjectType { get; set; }
        public DbSet<D_ProjectParties> D_ProjectParties { get; set; }
        public DbSet<D_ProjectManager> D_ProjectManager{ get; set; }
        public DbSet<D_Contractor> D_Contractor { get; set; }
        public DbSet<D_DpDicipline> D_DpDicipline { get; set; }
        public DbSet<D_ClientDicipline> D_ClientDicipline { get; set; }
        public DbSet<D_Phase> D_Phase { get; set; }
        public DbSet<D_Unit> D_Unit { get; set; }
        public DbSet<D_DocumentType> D_DocumentType { get; set; }
        public DbSet<D_Classification> D_Classification { get; set; }
        public DbSet<D_Stage> D_Stage { get; set; }
        public DbSet<D_Progress> D_Progress { get; set; }
        public DbSet<D_CommentSheetStage> D_CommentSheetStage { get; set; }
        public DbSet<D_ReplySheetStage> D_ReplySheetStage { get; set; }
        public DbSet<D_RetReplysheetStage> D_RetReplysheetStage { get; set; }
        public DbSet<D_SentType> D_SentType { get; set; }
        public DbSet<D_PaperSize> D_PaperSize { get; set; }
        public DbSet<D_AdditionalWork> D_AdditionalWork { get; set; }
        public DbSet<D_Area> D_Area { get; set; }
        public DbSet<D_Section> D_Section { get; set; }
        public DbSet<D_MDR> D_MDR { get; set; }
        public DbSet<D_ProjectBudget> D_ProjectBudjet { get; set; }

        public DbSet<A_UserManager> A_UserManager { get; set; }
        public DbSet<D_Position>D_Position{ get; set; }
        public DbSet<D_ProjectMembers> D_ProjectMembers { get; set; }
        public DbSet<U_ExternalLetters> U_ExternalLetters { get; set; }
        public DbSet<U_LetterRecipents> U_LetterRecipents { get; set; }
        public DbSet<U_ExLetterAttachments> U_ExLetterAttachments { get; set; }
        public DbSet<A_AdministrativeForm> A_AdministrativeForm { get; set; }
        public DbSet<D_Revision> D_Revision { get; set; }
       public DbSet<D_RevisionCode> D_RevisionCode { get; set; }
        public DbSet<Reports> Reports { get; set; }
      public DbSet<D_UserProject> D_UserProject { get; set; }
        public DbSet<P_ContactInf> P_ContactInf { get; set; }
        public DbSet<P_VaziatKhedmat> P_VaziatKhedmat { get; set; }
        public DbSet<P_BankAccountDetails> P_BankAccountDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<D_UserProject>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_BankAccountDetails>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_VaziatKhedmat>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_ContactInf>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });


            builder.Entity<Reports>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            
            builder.Entity<D_RetReplysheetStage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            
            
            builder.Entity<D_Revision>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            
            builder.Entity<D_RevisionCode>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            
            builder.Entity<A_UserManager>(entity =>
            {
                entity.ToTable(name: "A_UserManager");
               
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            
            builder.Entity<U_ExternalLetters>(entity =>
            {
                entity.Property(e => e.LetterID).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Position>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_ProjectMembers>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<A_UserManager>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_ProjectBudget>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            
            builder.Entity<D_MDR>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            
            builder.Entity<D_Area>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
           
            builder.Entity<D_Section>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_AdditionalWork>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_PaperSize>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_SentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_ReplySheetStage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_CommentSheetStage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Progress>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Stage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Classification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_DocumentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Unit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Phase>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_ClientDicipline>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_DpDicipline>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Contractor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_ProjectManager>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_ProjectParties>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_ProjectType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_City>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_Department>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_Company>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_JobCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_MahalKhedmat>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_Post>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<D_Project>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<P_Personel>(entity =>
            {
                entity.Property(e => e.WorkPlace).HasColumnName("WorkPlace");

            });
            builder.Entity<P_WorkPlace>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

            });
            builder.Entity<ApplicationRoles>(entity =>
            {
                entity.ToTable(name: "Roles_Tbl");
            });
        }
    }
}
