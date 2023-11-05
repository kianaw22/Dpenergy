using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Entities.DMS.Stackholders;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS.Stackholders;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.Stackholders
{
    [Area("DMSArea")]
    public class ProjectMembersController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public ProjectMembersController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.ProjectMembersUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddProjectMembers()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProjectMembers(D_ProjectMembersViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                model.CreationDate = DateTime.Now;
                _context.ProjectMembersUW.Create(_mapper.Map<D_ProjectMembers>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditProjectMembers(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ProjectMembersUW.GetById(Id);
            var mapproj = _mapper.Map<D_ProjectMembersViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProjectMembers(D_ProjectMembersViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_ProjectMembers>(model);
                _context.ProjectMembersUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteProjectMembers(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ProjectMembersUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteProjectMembers", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProjectMembersPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.ProjectMembersUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;

            List<D_Position> ListPosition = _context.PositionManagerUW.Get().ToList();
            ViewBag.positionlist = ListPosition;

        }
    }
}