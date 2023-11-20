using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Entities.DMS.Stackholders;
using DPEnergy.DataModelLayer.Entities.Reporrts;
using DPEnergy.DataModelLayer.Entities.User;
using DPEnergy.DataModelLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Services
{
    public interface IUnitOfWork
    {
        public GenericClass<U_ExLetterAttachments> LetterAttachmentsUW { get; }
        public GenericClass<A_UserManager> UserManagerUW { get; }
        public GenericClass<P_Personel> PersonelUW { get; }
        public GenericClass<P_City> CityManagerUW { get; }
        public GenericClass<P_Department> DepartmentManagerUW { get; }
        public GenericClass<P_Company> CompanyManagerUW { get; }

        public GenericClass<P_JobCategory> JobCategoryManagerUW { get; }
        public GenericClass<P_MahalKhedmat> MahalKhedmatManagerUW { get; }
        public GenericClass<P_Post> PostManagerUW { get; }
        public GenericClass<P_WorkPlace> WorkPlaceManagerUW { get; }
        public GenericClass<D_Project> projectManagerUW { get; }
        public GenericClass<D_ProjectType> ProjectTypeManagerUW { get; }
        public GenericClass<D_ProjectParties> ProjectPartiesManagerUW { get; }
        public GenericClass<D_ProjectManager> ProjectManagerManagerUW { get; }
        public GenericClass<D_Contractor> ContractorManagerUW { get; }
        public GenericClass<D_DpDicipline> DpDiciplineManagerUW { get; }
        public GenericClass<D_ClientDicipline> ClientDiciplineManagerUW { get; }
        public GenericClass<D_Phase> PhaseManagerUW { get; }
        public GenericClass<D_Unit> UnitManagerUW { get; }
        public GenericClass<D_DocumentType> DocumentTypeManagerUW { get; }
        public GenericClass<D_Classification> ClassificationManagerUW { get; }
        public GenericClass<D_Stage> StageManagerUW { get; }
        public GenericClass<D_Progress> ProgressManagerUW { get; }
        public GenericClass<D_CommentSheetStage> CommentSheetStageManagerUW { get; }
        public GenericClass<D_ReplySheetStage> ReplySheetStageManagerUW { get; }
        public GenericClass<D_SentType> SentTypeManagerUW { get; }
        public GenericClass<D_PaperSize> PaperSizeManagerUW { get; }
        public GenericClass<D_AdditionalWork> AdditionalWorkManagerUW { get; }
        public GenericClass<D_Area> AreaManagerUW { get; }
        public GenericClass<D_Section> SectionManagerUW { get; }
        public GenericClass<D_MDR> MDRManagerUW { get; }
        public GenericClass<D_ProjectBudget> ProjectBudgetManagerUW { get; }
        public GenericClass<A_UserManager> UserManagerManagerUW { get; }
        public GenericClass<ApplicationRoles> RoleManagerUW { get; }
        public GenericClass<A_RolePattern> RolePatternUW { get; }
        public GenericClass<A_RolePatternDetails> RolePatternDetailsUW { get; }
        public GenericClass<D_Position> PositionManagerUW { get; }
        public GenericClass<D_ProjectMembers> ProjectMembersUW { get; }
        
        public GenericClass<U_ExternalLetters> ExternalLettersUW { get; }
        public GenericClass<A_AdministrativeForm> AdministrativeFormUW { get; }
        public GenericClass<U_LetterRecipents> LetterRecipentsUW { get; }
        public GenericClass<D_Revision> RevisionUW { get; }
        public GenericClass<D_RevisionCode> RevisionCodeUW { get; }
        public GenericClass<D_RetReplysheetStage> RetReplySheetStageUW { get; }
        public GenericClass<Reports> ReportsUW { get; }
        public GenericClass<D_UserProject> UserProjectUW { get; }

        void save();
        void Dispose();
    }
}
