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
    public class AdditionalWorkController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public AdditionalWorkController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.AdditionalWorkManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddAdditionalWork()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAdditionalWork(D_AdditionalWorkViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                model.CreationDate = DateTime.Now;
                _context.AdditionalWorkManagerUW.Create(_mapper.Map<D_AdditionalWork>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditAdditionalWork(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.AdditionalWorkManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_AdditionalWorkViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditAdditionalWork(D_AdditionalWorkViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_AdditionalWork>(model);
                _context.AdditionalWorkManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteAdditionalWork(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.AdditionalWorkManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteAdditionalWork", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteAdditionalWorkPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.AdditionalWorkManagerUW.DeleteById(Id);
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