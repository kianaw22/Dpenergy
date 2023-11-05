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
    public class UnitController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public UnitController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.UnitManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddUnit()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUnit(D_UnitViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                model.CreationDate = DateTime.Now;
                _context.UnitManagerUW.Create(_mapper.Map<D_Unit>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditUnit(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.UnitManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_UnitViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUnit(D_UnitViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_Unit>(model);
                _context.UnitManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteUnit(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.UnitManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteUnit", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUnitPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.UnitManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
           
        }
    }
}