using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Entities.DMS.Stackholders;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Entities.Reporrts;
using DPEnergy.DataModelLayer.Entities.User;
using DPEnergy.DataModelLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPEnergy.DataModelLayer.Services
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext db)
        {
            _context = db;
        }

        private GenericClass<A_UserManager> _userManager;
        private GenericClass<ApplicationRoles> _roleManager;
        private GenericClass<P_Personel> _personelManager;
        private GenericClass<P_City> _cityManager;
        private GenericClass<P_Department> _departmentManager;
        private GenericClass<P_Company> _companyManager;
        private GenericClass<P_JobCategory> _jobcategoryManager;
        private GenericClass<P_MahalKhedmat> _mahalkhedmatManager;
        private GenericClass<P_Post> _postManager;
        private GenericClass<P_WorkPlace> _workplaceManager;
        private GenericClass<D_Project> _projectManager;
        private GenericClass<D_ProjectType> _projecttypeManager;
        private GenericClass<D_ProjectParties> _projectpartiesManager;
        private GenericClass<D_ProjectManager> _projectManagerManager;
        private GenericClass<D_Contractor> _contractorManager;
        private GenericClass<D_DpDicipline> _dpdiciplineManager;
        private GenericClass<D_ClientDicipline> _clientdiciplineManager;
        private GenericClass<D_Phase> _phaseManager;
        private GenericClass<D_Unit> _unitManager;
        private GenericClass<D_DocumentType> _documnettypeManager;
        private GenericClass<D_Classification> _classificationManager;
        private GenericClass<D_Stage> _StageManager;
        private GenericClass<D_Progress> _progressManager;
        private GenericClass<D_CommentSheetStage> _commentsheetstageManager;
        private GenericClass<D_ReplySheetStage> _replytsheetstageManager;
        private GenericClass<D_SentType> _senttypeManager;
        private GenericClass<D_PaperSize> _papersizeManager;
        private GenericClass<D_AdditionalWork> _additionalworkManager;
        private GenericClass<D_Area> _areaManager;
        private GenericClass<D_Section> _sectionManager;
        private GenericClass<D_MDR> _mdrManager;
        private GenericClass<D_ProjectBudget> _projectbudgetManager;
        private GenericClass<A_UserManager> _usermanagerManager;
        private GenericClass<A_RolePattern> _rolepatternManager;
        private GenericClass<A_RolePatternDetails> _rolepatterndetailsManager;
        private GenericClass<D_Position> _positionManager;
        private GenericClass<D_ProjectMembers> _projectmembers;
        private GenericClass<U_ExternalLetters> _externalletters;
        private GenericClass<A_AdministrativeForm> _administrativeform;
        private GenericClass<U_LetterRecipents> _letterrecipents;
        private GenericClass<U_ExLetterAttachments> _letterattachs;
        private GenericClass<D_Revision> _revision;
        private GenericClass<D_RevisionCode> _revisioncode;
        private GenericClass<D_RetReplysheetStage> _retreplysheetstage;
        private GenericClass<Reports> _reports;
        private GenericClass<D_UserProject> _userproject;
        private GenericClass<P_ContactInf>_contactinf;
        private GenericClass<P_VaziatKhedmat> _vaziatkhedmat;
        private GenericClass<P_BankAccountDetails> _bankaccountdetails;
        private GenericClass<P_Takafol> _takafol;
        private GenericClass<P_SabegheKar> _sabeghekar;
        private GenericClass<P_Bime> _bime;
        private GenericClass<P_Course> _course;
        private GenericClass<P_MadrakTahsili> _madrak;
        private GenericClass<P_LetterRequest> _letterrequest;
        private GenericClass<P_FieldOfStudy> _fieldofstudy;
        private GenericClass<P_InstitutionName> _instituionname;
        public GenericClass<P_InsuranceStatus> _insurancestatus;
        public GenericClass<P_AccountType> _accounttype;
        public GenericClass<P_EducationDegree> _educationdegree;
        public GenericClass<P_DocumentType> _documenttype;
        public GenericClass<P_PersonelStatus> _personelstatus;
        public GenericClass<P_MaritalStatus> _maritalstatus;
        public GenericClass<P_ContractType> _contracttype;
        public GenericClass<P_DocumentType>DocumentTypeUW
        {
            get
            {
                if (_documenttype == null)
                {
                    _documenttype = new GenericClass<P_DocumentType>(_context);
                }
                return _documenttype;
            }
        }
        public GenericClass<P_ContractType> ContractTypeUW
        {
            get
            {
                if (_contracttype == null)
                {
                    _contracttype = new GenericClass<P_ContractType>(_context);
                }
                return _contracttype;
            }
        }
        public GenericClass<P_MaritalStatus> MaritalStatusUW
        {
            get
            {
                if (_maritalstatus == null)
                {
                    _maritalstatus = new GenericClass<P_MaritalStatus>(_context);
                }
                return _maritalstatus;
            }
        }
        public GenericClass<P_PersonelStatus> PersonelStatusUW
        {
            get
            {
                if (_personelstatus == null)
                {
                    _personelstatus = new GenericClass<P_PersonelStatus>(_context);
                }
                return _personelstatus;
            }
        }
        public GenericClass<P_EducationDegree> EducationDegreeUW
        {
            get
            {
                if (_educationdegree == null)
                {
                    _educationdegree = new GenericClass<P_EducationDegree>(_context);
                }
                return _educationdegree;
            }
        }
        public GenericClass<P_AccountType> AccountTypeUW
        {
            get
            {
                if (_accounttype == null)
                {
                    _accounttype = new GenericClass<P_AccountType>(_context);
                }
                return _accounttype;
            }
        }
        public GenericClass<P_InsuranceStatus> InsuranceStatusUW
        {
            get
            {
                if (_insurancestatus == null)
                {
                    _insurancestatus = new GenericClass<P_InsuranceStatus>(_context);
                }
                return _insurancestatus;
            }
        }
        public GenericClass<P_InstitutionName> InstitutionNameUW
        {
            get
            {
                if (_instituionname == null)
                {
                    _instituionname = new GenericClass<P_InstitutionName>(_context);
                }
                return _instituionname;
            }
        }
        public GenericClass<P_FieldOfStudy> FieldofStudyUW
        {
            get
            {
                if (_fieldofstudy == null)
                {
                    _fieldofstudy = new GenericClass<P_FieldOfStudy>(_context);
                }
                return _fieldofstudy;
            }
        }
        public GenericClass<P_Course> CourseUW
        {
            get
            {
                if (_course == null)
                {
                    _course = new GenericClass<P_Course>(_context);
                }
                return _course;
            }
        }
        public GenericClass<P_LetterRequest> LetterRequestUW
        {
            get
            {
                if (_letterrequest == null)
                {
                    _letterrequest = new GenericClass<P_LetterRequest>(_context);
                }
                return _letterrequest;
            }
        }
        public GenericClass<P_MadrakTahsili> MadrakTahsiliUW
        {
            get
            {
                if (_madrak == null)
                {
                    _madrak = new GenericClass<P_MadrakTahsili>(_context);
                }
                return _madrak;
            }
        }
        public GenericClass<P_Bime> BimeUW
        {
            get
            {
                if (_bime == null)
                {
                    _bime = new GenericClass<P_Bime>(_context);
                }
                return _bime;
            }
        }
        public GenericClass<P_SabegheKar> SabegheKarUW
        {
            get
            {
                if (_sabeghekar == null)
                {
                    _sabeghekar = new GenericClass<P_SabegheKar>(_context);
                }
                return _sabeghekar;
            }
        }
        public GenericClass<P_Takafol> TakafolUW
        {
            get
            {
                if (_takafol == null)
                {
                    _takafol = new GenericClass<P_Takafol>(_context);
                }
                return _takafol;
            }
        }
        public GenericClass<P_ContactInf> ContactInfUW
        {
            get
            {
                if (_contactinf == null)
                {
                    _contactinf = new GenericClass<P_ContactInf>(_context);
                }
                return _contactinf;
            }
        }
        public GenericClass<P_VaziatKhedmat> VaziatKhedmatUW
        {
            get
            {
                if (_vaziatkhedmat == null)
                {
                    _vaziatkhedmat = new GenericClass<P_VaziatKhedmat>(_context);
                }
                return _vaziatkhedmat;
            }
        }
        public GenericClass<P_BankAccountDetails> BankAccountDetailsUW
        {
            get
            {
                if (_bankaccountdetails == null)
                {
                    _bankaccountdetails = new GenericClass<P_BankAccountDetails>(_context);
                }
                return _bankaccountdetails;
            }
        }
        public GenericClass<D_UserProject> UserProjectUW
        {
            get
            {
                if (_userproject == null)
                {
                    _userproject = new GenericClass<D_UserProject>(_context);
                }
                return _userproject;
            }
        }
        public GenericClass<Reports>ReportsUW
        {
            get
            {
                if (_reports == null)
                {
                    _reports = new GenericClass<Reports>(_context);
                }
                return _reports;
            }
        }
        public GenericClass<D_RetReplysheetStage> RetReplySheetStageUW
        {
            get
            {
                if (_retreplysheetstage == null)
                {
                    _retreplysheetstage = new GenericClass<D_RetReplysheetStage>(_context);
                }
                return _retreplysheetstage;
            }
        }
        public GenericClass<D_RevisionCode> RevisionCodeUW
        {
            get
            {
                if (_revisioncode == null)
                {
                    _revisioncode = new GenericClass<D_RevisionCode>(_context);
                }
                return _revisioncode;
            }
        }
        public GenericClass<D_Revision> RevisionUW
        {
            get
            {
                if (_revision == null)
                {
                    _revision = new GenericClass<D_Revision>(_context);
                }
                return _revision;
            }
        }
        
        public GenericClass<U_ExLetterAttachments> LetterAttachmentsUW
        {
            get
            {
                if (_letterattachs == null)
                {
                    _letterattachs = new GenericClass<U_ExLetterAttachments>(_context);
                }
                return _letterattachs;
            }
        }
        public GenericClass<U_LetterRecipents> LetterRecipentsUW
        {
            get
            {
                if (_letterrecipents == null)
                {
                    _letterrecipents = new GenericClass<U_LetterRecipents>(_context);
                }
                return _letterrecipents;
            }
        }
        public GenericClass<A_UserManager> UserManagerUW
        {
            get
            {
                if (_userManager == null)
                {
                    _userManager = new GenericClass<A_UserManager>(_context);
                }
                return _userManager;
            }
        }
        public GenericClass<A_AdministrativeForm> AdministrativeFormUW
        {
            get
            {
                if (_administrativeform == null)
                {
                    _administrativeform = new GenericClass<A_AdministrativeForm>(_context);
                }
                return _administrativeform;
            }
        }
        public GenericClass<U_ExternalLetters> ExternalLettersUW
        {
            get
            {
                if (_externalletters == null)
                {
                    _externalletters = new GenericClass<U_ExternalLetters>(_context);
                }
                return _externalletters;
            }
        }
        public GenericClass<D_ProjectMembers> ProjectMembersUW
        {
            get
            {
                if (_projectmembers == null)
                {
                    _projectmembers = new GenericClass<D_ProjectMembers>(_context);
                }
                return _projectmembers;
            }
        }
        public GenericClass<D_Position> PositionManagerUW
        {
            get
            {
                if (_positionManager == null)
                {
                    _positionManager = new GenericClass<D_Position>(_context);
                }
                return _positionManager;
            }
        }
        public GenericClass<A_RolePatternDetails> RolePatternDetailsUW
        {
            get
            {
                if (_rolepatterndetailsManager == null)
                {
                    _rolepatterndetailsManager = new GenericClass<A_RolePatternDetails>(_context);
                }
                return _rolepatterndetailsManager;
            }
        }
        public GenericClass<A_RolePattern> RolePatternUW
        {
            //فقط خواندنی    
            get
            {
                if (_rolepatternManager == null)
                {
                    _rolepatternManager = new GenericClass<A_RolePattern>(_context);
                }
                return _rolepatternManager;
            }
        }
        public GenericClass<A_UserManager> UserManagerManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_usermanagerManager == null)
                {
                    _usermanagerManager = new GenericClass<A_UserManager>(_context);
                }
                return _usermanagerManager;
            }
        }
        public GenericClass<ApplicationRoles> RoleManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_roleManager == null)
                {
                    _roleManager = new GenericClass<ApplicationRoles>(_context);
                }
                return _roleManager;
            }
        }
        public GenericClass<D_ProjectBudget> ProjectBudgetManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_projectbudgetManager == null)
                {
                    _projectbudgetManager = new GenericClass<D_ProjectBudget>(_context);
                }
                return _projectbudgetManager;
            }
        }
        //سکشن
        public GenericClass<D_MDR> MDRManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_mdrManager == null)
                {
                    _mdrManager = new GenericClass<D_MDR>(_context);
                }
                return _mdrManager;
            }
        }
        //سکشن
        public GenericClass<D_Section> SectionManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_sectionManager == null)
                {
                    _sectionManager = new GenericClass<D_Section>(_context);
                }
                return _sectionManager;
            }
        }
        //ناحیه
        public GenericClass<D_Area> AreaManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_areaManager == null)
                {
                    _areaManager = new GenericClass<D_Area>(_context);
                }
                return _areaManager;
            }
        }
        //اضافه کار
        public GenericClass<D_AdditionalWork> AdditionalWorkManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_additionalworkManager == null)
                {
                    _additionalworkManager = new GenericClass<D_AdditionalWork>(_context);
                }
                return _additionalworkManager;
            }
        }
        //سایز کاغذ
        public GenericClass<D_PaperSize> PaperSizeManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_papersizeManager == null)
                {
                    _papersizeManager = new GenericClass<D_PaperSize>(_context);
                }
                return _papersizeManager;
            }
        }
        //نوع محتوای فرستاده شده
        public GenericClass<D_SentType> SentTypeManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_senttypeManager == null)
                {
                    _senttypeManager = new GenericClass<D_SentType>(_context);
                }
                return _senttypeManager;
            }
        }
        //استیج ریپلای شیت
        public GenericClass<D_ReplySheetStage> ReplySheetStageManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_replytsheetstageManager == null)
                {
                    _replytsheetstageManager = new GenericClass<D_ReplySheetStage>(_context);
                }
                return _replytsheetstageManager;
            }
        }
        //استیج کامنت شیت
        public GenericClass<D_CommentSheetStage> CommentSheetStageManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_commentsheetstageManager == null)
                {
                    _commentsheetstageManager = new GenericClass<D_CommentSheetStage>(_context);
                }
                return _commentsheetstageManager;
            }
        }
        //پروگرس
        public GenericClass<D_Progress> ProgressManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_progressManager == null)
                {
                    _progressManager = new GenericClass<D_Progress>(_context);
                }
                return _progressManager;
            }
        }
        //استیج
        public GenericClass<D_Stage> StageManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_StageManager == null)
                {
                    _StageManager = new GenericClass<D_Stage>(_context);
                }
                return _StageManager;
            }
        }
        //کلاس بندی
        public GenericClass<D_Classification> ClassificationManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_classificationManager == null)
                {
                    _classificationManager = new GenericClass<D_Classification>(_context);
                }
                return _classificationManager;
            }
        }
        //نوع مدرک 
        public GenericClass<D_DocumentType> DocumentTypeManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_documnettypeManager == null)
                {
                    _documnettypeManager = new GenericClass<D_DocumentType>(_context);
                }
                return _documnettypeManager;
            }
        }
        //یونیت
        public GenericClass<D_Unit> UnitManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_unitManager == null)
                {
                    _unitManager = new GenericClass<D_Unit>(_context);
                }
                return _unitManager;
            }
        }
        //فاز
        public GenericClass<D_Phase> PhaseManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_phaseManager == null)
                {
                    _phaseManager = new GenericClass<D_Phase>(_context);
                }
                return _phaseManager;
            }
        }
        public GenericClass<D_ClientDicipline> ClientDiciplineManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_clientdiciplineManager == null)
                {
                    _clientdiciplineManager = new GenericClass<D_ClientDicipline>(_context);
                }
                return _clientdiciplineManager;
            }
        }
        //دیسیپلین
        public GenericClass<D_DpDicipline> DpDiciplineManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_dpdiciplineManager == null)
                {
                    _dpdiciplineManager = new GenericClass<D_DpDicipline>(_context);
                }
                return _dpdiciplineManager;
            }
        }
        //کانترکتور
        public GenericClass<D_Contractor> ContractorManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_contractorManager == null)
                {
                    _contractorManager = new GenericClass<D_Contractor>(_context);
                }
                return _contractorManager;
            }
        }
        //پروژه منیجر
        public GenericClass<D_ProjectManager> ProjectManagerManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_projectManagerManager == null)
                {
                    _projectManagerManager = new GenericClass<D_ProjectManager>(_context);
                }
                return _projectManagerManager;
            }
        }
        //پروژه پارتی
        public GenericClass<D_ProjectParties>ProjectPartiesManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_projectpartiesManager == null)
                {
                    _projectpartiesManager = new GenericClass<D_ProjectParties>(_context);
                }
                return _projectpartiesManager;
            }
        }
        //نوع پروژه
        public GenericClass<D_ProjectType> ProjectTypeManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_projecttypeManager == null)
                {
                    _projecttypeManager = new GenericClass<D_ProjectType>(_context);
                }
                return _projecttypeManager;
            }
        }

        //پروژه ها
        public GenericClass<D_Project> projectManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_projectManager == null)
                {
                    _projectManager = new GenericClass<D_Project>(_context);
                }
                return _projectManager;
            }
        }
        //شهر ها
        public GenericClass<P_City> CityManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_cityManager == null)
                {
                    _cityManager = new GenericClass<P_City>(_context);
                }
                return _cityManager;
            }
        }
        //دپارتمان
        public GenericClass<P_Department> DepartmentManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_departmentManager == null)
                {
                    _departmentManager = new GenericClass<P_Department>(_context);
                }
                return _departmentManager;
            }
        }
        //شرکت 
        public GenericClass<P_Company> CompanyManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_companyManager == null)
                {
                    _companyManager = new GenericClass<P_Company>(_context);
                }
                return _companyManager;
            }
        }
        //رده شغلی
        public GenericClass<P_JobCategory> JobCategoryManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_jobcategoryManager == null)
                {
                    _jobcategoryManager = new GenericClass<P_JobCategory>(_context);
                }
                return _jobcategoryManager;
            }
        }
        //محل خدمت
        public GenericClass<P_MahalKhedmat> MahalKhedmatManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_mahalkhedmatManager == null)
                {
                    _mahalkhedmatManager = new GenericClass<P_MahalKhedmat>(_context);
                }
                return _mahalkhedmatManager;
            }
        }
        //پست
        public GenericClass<P_Post> PostManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_postManager == null)
                {
                    _postManager = new GenericClass<P_Post>(_context);
                }
                return _postManager;
            }
        }
        //محل کار 
        public GenericClass<P_WorkPlace> WorkPlaceManagerUW
        {
            //فقط خواندنی    
            get
            {
                if (_workplaceManager == null)
                {
                    _workplaceManager = new GenericClass<P_WorkPlace>(_context);
                }
                return _workplaceManager;
            }
        }
        //پرسنل
        public GenericClass<P_Personel> PersonelUW
        {
            //فقط خواندنی    
            get
            {
                if (_personelManager == null)
                {
                    _personelManager = new GenericClass<P_Personel>(_context);
                }
                return _personelManager;
            }
        }

        

        public void save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
