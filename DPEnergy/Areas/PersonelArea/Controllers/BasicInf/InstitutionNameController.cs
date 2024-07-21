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
    public class InstitutionNameController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public InstitutionNameController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.InstitutionNameUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddInstitutionName()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddInstitutionName(P_InstitutionNameViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.InstitutionNameUW.Create(_mapper.Map<P_InstitutionName>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditInstitutionName(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.InstitutionNameUW.GetById(Id);
            var mapwp = _mapper.Map<P_InstitutionNameViewModel>(wp);
            return View(mapwp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditInstitutionName(P_InstitutionNameViewModel model)
        {
            if (ModelState.IsValid)
            {
                var wpmapper = _mapper.Map<P_InstitutionName>(model);
                _context.InstitutionNameUW.Update(wpmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteInstitutionName(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.InstitutionNameUW.GetById(Id);
            if (wp == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteInstitutionName", wp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteInstitutionNamePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.InstitutionNameUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}