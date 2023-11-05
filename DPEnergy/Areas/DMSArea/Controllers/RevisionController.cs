using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS;
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
        public RevisionController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _context = uow;
            _mapper = mapper;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var model = _context.RevisionUW.Get();
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
            List<D_MDR> ListMDR = _context.MDRManagerUW.Get().ToList();
            ViewBag.mdrlist = ListMDR;
            if (buttonId == "Cancel")
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
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
                return RedirectToAction("ErrorView", "Home");
            }

            var rev = _context.RevisionUW.GetById(Id);
            var projcode = rev.ProjectCode;
            var projtitle = _context.projectManagerUW.Get(x => x.ProjectCode == projcode).ToList()[0].Title;
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
            if (buttonId == "Cancel")
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_Revision>(model);
                _context.RevisionUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
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
                return RedirectToAction("ErrorView", "Home");
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
                return RedirectToAction("ErrorView", "Home");
            }
            _context.RevisionUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public IActionResult GetProgress(string stage)
        {
            if (stage == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var data = _context.ProgressManagerUW.Get(x => x.Stage == stage).ToList()[0].Percent;
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
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
            
        }
    }
}
