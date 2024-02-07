using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Entities.DMS.Stackholders;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Entities.Reporrts;
using DPEnergy.DataModelLayer.Entities.User;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.ViewModels.Admin;
using DPEnergy.DataModelLayer.ViewModels.DMS;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using DPEnergy.DataModelLayer.ViewModels.DMS.Stackholders;
using DPEnergy.DataModelLayer.ViewModels.Personel;
using DPEnergy.DataModelLayer.ViewModels.Reports;
using DPEnergy.DataModelLayer.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DPEnergy.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<P_Personel, PersonelViewModel>().ReverseMap();
            CreateMap<P_City, P_CityViewModel>().ReverseMap();
            CreateMap<P_Department, DepartmentViewModel>().ReverseMap();
            CreateMap<P_Company, P_CompanyViewModel>().ReverseMap();
            CreateMap<P_JobCategory, P_JobCategoryViewModel>().ReverseMap();
            CreateMap<P_MahalKhedmat, P_MahalKhedmatViewModel>().ReverseMap();
            CreateMap<P_Post, P_PostViewModel>().ReverseMap();
            CreateMap<P_WorkPlace, P_WorkPlaceViewModel>().ReverseMap();
            CreateMap<D_Project, D_ProjectViewModel>().ReverseMap();
            CreateMap<D_ProjectType, D_ProjectTypeViewModel>().ReverseMap();
            CreateMap<D_ProjectParties, D_ProjectPartiesViewModel>().ReverseMap();
            CreateMap<D_ProjectManager, D_ProjectManagerViewModel>().ReverseMap();
            CreateMap<D_Contractor, D_ContractorViewModel>().ReverseMap();
            CreateMap<D_DpDicipline, D_DpDiciplineViewModel>().ReverseMap();
            CreateMap<D_ClientDicipline, D_ClientDiciplineViewModel>().ReverseMap();
            CreateMap<D_Phase, D_PhaseViewModel>().ReverseMap();
            CreateMap<D_Unit, D_UnitViewModel>().ReverseMap();
            CreateMap<D_DocumentType, D_DocumentTypeViewModel>().ReverseMap();
            CreateMap<D_Classification, D_ClassificationViewModel>().ReverseMap();
            CreateMap<D_Stage, D_StageViewModel>().ReverseMap();
            CreateMap<D_Progress, D_ProgressViewModel>().ReverseMap();
            CreateMap<D_CommentSheetStage, D_CommentSheetStageViewModel>().ReverseMap();
            CreateMap<D_ReplySheetStage, D_ReplySheetStageViewModel>().ReverseMap();
            CreateMap<D_SentType, D_SentTypeViewModel>().ReverseMap();
            CreateMap<D_PaperSize, D_PaperSizeViewModel>().ReverseMap();
            CreateMap<D_AdditionalWork, D_AdditionalWorkViewModel>().ReverseMap();
            CreateMap<D_Area, D_AreaViewModel>().ReverseMap();
            CreateMap<D_Section, D_SectionViewModel>().ReverseMap();
            CreateMap<D_MDRViewModel, D_MDR >().ReverseMap().ForMember(x => x.ProjectTitle, x => x.Ignore()); ;
            CreateMap<D_ProjectBudget, D_ProjectBudgetViewModel>().ReverseMap();
            CreateMap<A_UserManager, A_UserManagerViewModel>().ReverseMap();
            CreateMap<ApplicationRoles, RoleViewModel>().ReverseMap();
            CreateMap<D_Position, D_PositionViewModel>().ReverseMap();
            CreateMap<D_ProjectMembers, D_ProjectMembersViewModel>().ReverseMap();
            CreateMap<A_AdministrativeForm, A_AdministrativeFormViewModel>().ReverseMap();
            CreateMap<U_ExternalLetters, ExternalLettersViewModel>().ReverseMap();
            CreateMap<D_RevisionViewModel, D_Revision>().ReverseMap().ForMember(x => x.ProjectTitle, x => x.Ignore());
            CreateMap<D_RevisionCode, D_RevisionCodeViewModel>().ReverseMap();
            CreateMap<D_RetReplysheetStage, D_RetReplysheetStageViewModel>().ReverseMap();
            CreateMap<Reports, ReportsViewModel>().ReverseMap();
            CreateMap<D_UserProject, D_UserProjectViewModel>().ReverseMap();
            CreateMap<P_BankAccountDetails, P_BankAccountDetailsViewModel>().ReverseMap();
            CreateMap<P_ContactInf, P_ContactInfViewModel>().ReverseMap();
            CreateMap<P_VaziatKhedmat, P_VaziatKhedmatViewModel>().ReverseMap();

        }
    }
}
