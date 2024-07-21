using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    [Authorize(Roles = "DMSArea")]
    public class ProjectController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IHostingEnvironment _appEnvironment;


        public ProjectController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager,
            IHostingEnvironment appEnvironment)
        {
            _context = uow;
            _mapper = mapper;
            _userManager = userManager;
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index()
        {
            var model = _context.projectManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddProject()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProject(D_ProjectViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                model.CreationDate = DateTime.Now;
                model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                _context.projectManagerUW.Create(_mapper.Map<D_Project>(model));
                _context.save();
                var upload = Path.Combine(_appEnvironment.WebRootPath, "upload\\RevisionAttachments\\", model.ProjectCode);
                if (!Directory.Exists(upload))
                {
                    Directory.CreateDirectory(upload);
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditProject(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.projectManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_ProjectViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProject(D_ProjectViewModel model)
        {
            FillCombo();

            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                model.ModificationDate = DateTime.Now;
                model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                var projmapper = _mapper.Map<D_Project>(model);
                _context.projectManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteProject(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.projectManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteProject", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProjectPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var model = _context.projectManagerUW.GetById(Id);
            var upload = Path.Combine(_appEnvironment.WebRootPath, "upload\\RevisionAttachments\\",  model.ProjectCode);
            _context.projectManagerUW.DeleteById(Id);
            _context.save();
            
            if (Directory.Exists(upload))
            {
                Directory.Delete(upload, true);
            } 
            
              
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
            List<P_Personel> ListProjectManager = _context.PersonelUW.Get().ToList();
            ViewBag.projectmanagerlist = ListProjectManager;
            List<D_ProjectType> ListProjectType = _context.ProjectTypeManagerUW.Get().ToList();
            ViewBag.projecttypelist = ListProjectType;
            List<D_Contractor> ListContractor = _context.ContractorManagerUW.Get().ToList();
            ViewBag.contractorlist = ListContractor;
        }
    }
}