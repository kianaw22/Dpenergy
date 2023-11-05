using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    public class ProjectBudgetController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public ProjectBudgetController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.ProjectBudgetManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddProjectBudget()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProjectBudget(D_ProjectBudgetViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreationDate = DateTime.Now;
                _context.ProjectBudgetManagerUW.Create(_mapper.Map<D_ProjectBudget>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditProjectBudget(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ProjectBudgetManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_ProjectBudgetViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProjectBudget(D_ProjectBudgetViewModel model)
        {
            model.ModificationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_ProjectBudget>(model);
                _context.ProjectBudgetManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteProjectBudget(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ProjectBudgetManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteProjectBudget", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProjectBudgetPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.ProjectBudgetManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}