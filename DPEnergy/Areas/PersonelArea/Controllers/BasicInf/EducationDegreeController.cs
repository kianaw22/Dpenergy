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

namespace DPEnergy.Areas.PersonelArea.Controllers
{
    [Area("PersonelArea")]
    [Authorize]
    public class EducationDegreeController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public EducationDegreeController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.EducationDegreeUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddEducationDegree()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEducationDegree(P_EducationDegreeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.EducationDegreeUW.Create(_mapper.Map<P_EducationDegree>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditEducationDegree(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.EducationDegreeUW.GetById(Id);
            var mapwp = _mapper.Map<P_EducationDegreeViewModel>(wp);
            return View(mapwp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditEducationDegree(P_EducationDegreeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var wpmapper = _mapper.Map<P_EducationDegree>(model);
                _context.EducationDegreeUW.Update(wpmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteEducationDegree(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.EducationDegreeUW.GetById(Id);
            if (wp == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteEducationDegree", wp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEducationDegreePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.EducationDegreeUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}