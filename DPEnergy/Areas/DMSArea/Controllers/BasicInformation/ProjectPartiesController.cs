using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    public class ProjectPartiesController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public ProjectPartiesController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
       
        public IActionResult Index()
        {
            var model = _context.ProjectPartiesManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddProjectParties()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProjectParties(D_ProjectPartiesViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                _context.ProjectPartiesManagerUW.Create(_mapper.Map<D_ProjectParties>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditProjectParties(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ProjectPartiesManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_ProjectPartiesViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProjectParties(D_ProjectPartiesViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_ProjectParties>(model);
                _context.ProjectPartiesManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteProjectParties(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ProjectPartiesManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteProjectParties", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProjectPartiesPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.ProjectPartiesManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
            List<D_Contractor> ListCompanyName = _context.ContractorManagerUW.Get().ToList();
            ViewBag.companynamelist = ListCompanyName;
        }
    }
}