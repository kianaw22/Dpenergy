using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Personel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers.BasicInf
{
   
    [Area("PersonelArea")]
    [Authorize]
    public class FieldOfStudyController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public FieldOfStudyController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.FieldofStudyUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddFieldOfStudy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddFieldOfStudy(P_FieldOfStudyViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.FieldofStudyUW.Create(_mapper.Map<P_FieldOfStudy>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditFieldOfStudy(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.FieldofStudyUW.GetById(Id);
            var mapwp = _mapper.Map<P_FieldOfStudyViewModel>(wp);
            return View(mapwp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditFieldOfStudy(P_FieldOfStudyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var wpmapper = _mapper.Map<P_FieldOfStudy>(model);
                _context.FieldofStudyUW.Update(wpmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteFieldOfStudy(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.FieldofStudyUW.GetById(Id);
            if (wp == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteFieldOfStudy", wp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteFieldOfStudyPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.FieldofStudyUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}