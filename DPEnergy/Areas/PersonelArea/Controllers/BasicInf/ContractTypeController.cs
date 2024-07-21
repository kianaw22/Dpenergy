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
    public class ContractTypeController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public ContractTypeController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.ContractTypeUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddContractType()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddContractType(P_ContractTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.ContractTypeUW.Create(_mapper.Map<P_ContractType>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditContractType(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.ContractTypeUW.GetById(Id);
            var mapwp = _mapper.Map<P_ContractTypeViewModel>(wp);
            return View(mapwp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditContractType(P_ContractTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var wpmapper = _mapper.Map<P_ContractType>(model);
                _context.ContractTypeUW.Update(wpmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteContractType(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.ContractTypeUW.GetById(Id);
            if (wp == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteContractType", wp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteContractTypePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.ContractTypeUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}