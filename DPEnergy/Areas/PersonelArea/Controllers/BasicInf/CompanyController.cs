using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers.BasicInf
{
    
    [Area("PersonelArea")]
    [Authorize]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public CompanyController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.CompanyManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddCompany()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCompany(P_CompanyViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.CompanyManagerUW.Create(_mapper.Map<P_Company>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditCompany(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var comp = _context.CompanyManagerUW.GetById(Id);
            var mapcomp = _mapper.Map<P_CompanyViewModel>(comp);
            return View(mapcomp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCompany(P_CompanyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var compmapper = _mapper.Map<P_Company>(model);
                _context.CompanyManagerUW.Update(compmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteCompany(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.CompanyManagerUW.GetById(Id);
            if (city == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteCompany", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCompanyPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.CompanyManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}