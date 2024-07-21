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
    public class InsuranceStatusController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public InsuranceStatusController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.InsuranceStatusUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddInsuranceStatus()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddInsuranceStatus(P_InsuranceStatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.InsuranceStatusUW.Create(_mapper.Map<P_InsuranceStatus>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditInsuranceStatus(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.InsuranceStatusUW.GetById(Id);
            var mapwp = _mapper.Map<P_InsuranceStatusViewModel>(wp);
            return View(mapwp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditInsuranceStatus(P_InsuranceStatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                var wpmapper = _mapper.Map<P_InsuranceStatus>(model);
                _context.InsuranceStatusUW.Update(wpmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteInsuranceStatus(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.InsuranceStatusUW.GetById(Id);
            if (wp == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteInsuranceStatus", wp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteInsuranceStatusPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.InsuranceStatusUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}