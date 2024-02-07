using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.CommonLayer.Services;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DPEnergy.Areas.DMSArea.Controllers
{
    [Area("DMSArea")]
    public class RevisionController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IUploadFiles _upload;
        public RevisionController(IUploadFiles upload,IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _context = uow;
            _mapper = mapper;
            _userManager = userManager;
            _upload = upload;
        }
        public IActionResult UploadRevAttach(IEnumerable<IFormFile> filearray, string path, string projectcode
            , string name )
        {
            var result = _upload.UploadRevAttchment(filearray, path, projectcode , name);
            if (result.Item1 == true)
            {
                return Json(new { status = "duplicate" });
            }

            return Json(new { status = "success" , mypath =   result.Item2.Replace("\\" , "/")});

        }
        public IActionResult DeleteRevAttach(IEnumerable<IFormFile> filearray, string path, string projectcode
            , string name)
        {
            var result = _upload.DeleteFile( path, projectcode, name);
            if (result == false)
            {
                return Json(new { status = "nofile" });
            }

            return Json(new { status = "success" });

        }
        public IActionResult Index()
        {
            var model = _context.RevisionUW.Get().OrderBy(revision => revision.CreationDate);
            return View(model);
        }
        [HttpGet]
        public IActionResult SetProject()
        {
            FillCombo();
            return PartialView("_setProject");
        }
        [HttpGet]
        public IActionResult AddRevision(string ProjectID)
        {
         
            var projcode = _context.projectManagerUW.GetById(ProjectID).ProjectCode;
            var projtitle = _context.projectManagerUW.GetById(ProjectID).Title;
            FillRevcombo(projcode);
            var model = new D_RevisionViewModel
            {
                ProjectTitle= projtitle,
                ProjectCode=projcode, 
            };
        
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddRevision(D_RevisionViewModel model, string buttonId)
        {
            var projectcode = model.ProjectCode;
            FillRevcombo(projectcode);

            if (buttonId == "Cancel")
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                model.CreationDate = DateTime.Now;
                model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                _context.RevisionUW.Create(_mapper.Map<D_Revision>(model));
                _context.save();

                if (buttonId == "Save")
                {
                    return RedirectToAction("Index");
                }
                else if(buttonId=="Save and Next Item")
                {
                    var PID=_context.projectManagerUW.Get(x => x.ProjectCode == model.ProjectCode).ToList()[0].Id;
                    return RedirectToAction("AddRevision", new { ProjectID = PID });
                }
               
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditRevision(String Id)
        {

            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
           
            var rev = _context.RevisionUW.GetById(Id);
            var projcode = rev.ProjectCode;
            string projtitle = rev.ProjectTitle;
            FillRevcombo(projcode);
            var project = _context.projectManagerUW.Get(x => x.ProjectCode == projcode).ToList();
            if (project.Any())
            {
               projtitle = project[0].Title;
            }
            else
            {
                var errorMessage = "No project found for the specified project code.";
                return View("~/Views/Shared/Error.cshtml" ,errorMessage );
             }

            rev.ModificationDate = DateTime.Now;
            rev.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            var maprev = _mapper.Map<D_RevisionViewModel>(rev);
            maprev.ProjectTitle = projtitle;
            
            return View(maprev);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditRevision(D_RevisionViewModel model, string buttonId)
        {
           var projcode = model.ProjectCode;
           
            if (buttonId == "Cancel")
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                var projmapper = _mapper.Map<D_Revision>(model);
                _context.RevisionUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            FillRevcombo(projcode);
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteRevision(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.RevisionUW.GetById(Id);
            
            if (proj == null)
            {
                var errorMessage = "No project found for the selected row id.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            if ( proj.TransmittalNumber != null)
            {
                return Json("bad");
            }
            return PartialView("_deleteRevision", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRevisionPost(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No project id found to delete";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            _context.RevisionUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public IActionResult GetProgress(string stage , string projectcode)
        {
            if (stage == null)
            {
                var errorMessage = "stage cannot be null";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var data = _context.ProgressManagerUW.Get(x => x.Stage == stage && x.ProjectCode ==projectcode).ToList()[0].Percent;
            return Json(data);
        }
        [HttpGet]
        public IActionResult GetDocTitle ( string clientNumber)
        {
            if (clientNumber == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
          
            var data= _context.MDRManagerUW.Get(x => x.ClientNumber == clientNumber).ToList()[0] ;
            var doctitle = data.DocumentTitle;
            var dpnumber = data.DaryapalaNumber;
            var classification = data.Classification;
            var dpdicipline =data.DpDicipline;
            var clientdicipline = data.ClientDicipline;

            var a = new
            {
                DocTitle = doctitle,
                DpNumber = dpnumber,
                Classification = classification,
                DpDicipline = dpdicipline,
                ClientDicipline=clientdicipline

            };
           
            return Json(a);
        }
        public IActionResult RevHistoryGrid(string projectcode , string clientnumber)
        {
            var model = _context.RevisionUW.Get(x => x.ProjectCode == projectcode && x.ClientNumber == clientnumber);
            return Json(model);
        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
            
        }
        public void FillRevcombo(string projcode)
        {
            List<D_CommentSheetStage> ListCsheetStage = _context.CommentSheetStageManagerUW.Get(x => x.ProjectCode == projcode).ToList();
            ViewBag.csheetstage = ListCsheetStage;
            List<D_ReplySheetStage> ListRsheetStage = _context.ReplySheetStageManagerUW.Get(x => x.ProjectCode == projcode).ToList();
            ViewBag.rsheetstage = ListRsheetStage;
            List<D_RetReplysheetStage> ListRetsheetStage = _context.RetReplySheetStageUW.Get(x => x.ProjectCode == projcode).ToList();
            ViewBag.retsheetstage = ListRetsheetStage;
            List<D_RevisionCode> ListRevisionCode = _context.RevisionCodeUW.Get(x => x.ProjectCode == projcode).ToList();
            ViewBag.revisionCodelist = ListRevisionCode;
            List<D_MDR> ListMDR = _context.MDRManagerUW.Get(x => x.ProjectCode == projcode).ToList();
            ViewBag.mdrlist = ListMDR;
            List<D_Progress> ListProgress = _context.ProgressManagerUW.Get(x => x.ProjectCode == projcode).ToList();
            ViewBag.progresslist = ListProgress;
        }
    }
}
