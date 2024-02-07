using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    public class UserProjectController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        public UserProjectController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _context = uow;
            _mapper = mapper;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var model = _context.UserProjectUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddUserProject()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUserProject(D_UserProjectViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                model.ProjectCode = _context.projectManagerUW.GetById(model.ProjectId).ProjectCode;
                model.UserName = _context.UserManagerUW.GetById(model.UserId).UserName;
                model.CreationDate = DateTime.Now;
            
                var p = _context.projectManagerUW.Get(x => x.ProjectCode == model.ProjectCode);
                if (p != null && p.Any()){
                    var pp  = p.ToList()[0];
                    model.ProjectTitle = pp.Title;
                }
               
                model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                _context.UserProjectUW.Create(_mapper.Map<D_UserProject>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditUserProject(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.UserProjectUW.GetById(Id);
            var mapproj = _mapper.Map<D_UserProjectViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUserProject(D_UserProjectViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                model.ModificationDate = DateTime.Now;
                model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                var projmapper = _mapper.Map<D_UserProject>(model);
                _context.UserProjectUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteUserProject(string Id)
        {
            if (Id ==null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.UserProjectUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteUserProject", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUserProjectPost(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            _context.UserProjectUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
            List<A_UserManager> ListUser = _context.UserManagerUW.Get().ToList();
            ViewBag.userlist = ListUser;
           
        }
    }
}