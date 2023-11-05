using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers.BasicInf
{
    [Area("PersonelArea")]
    public class JobCategoryController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public JobCategoryController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.JobCategoryManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddJobCategory()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddJobCategory(P_JobCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.JobCategoryManagerUW.Create(_mapper.Map<P_JobCategory>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditJobCategory(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var jobc = _context.JobCategoryManagerUW.GetById(Id);
            var mapjobc = _mapper.Map<P_JobCategoryViewModel>(jobc);
            return View(mapjobc);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditJobCategory(P_JobCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var jobcmapper = _mapper.Map<P_JobCategory>(model);
                _context.JobCategoryManagerUW.Update(jobcmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteJobCategory(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var jobc = _context.JobCategoryManagerUW.GetById(Id);
            if (jobc == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteJobCategory", jobc);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteJobCategoryPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.JobCategoryManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}