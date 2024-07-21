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
    public class MahalKhedmatController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public MahalKhedmatController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var model = _context.MahalKhedmatManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddMahalKhedmat()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMahalKhedmat(P_MahalKhedmatViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.MahalKhedmatManagerUW.Create(_mapper.Map<P_MahalKhedmat>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditMahalKhedmat(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var khedmat = _context.MahalKhedmatManagerUW.GetById(Id);
            var mapkhedmat = _mapper.Map<P_MahalKhedmatViewModel>(khedmat);
            return View(mapkhedmat);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMahalKhedmat(P_MahalKhedmatViewModel model)
        {
            if (ModelState.IsValid)
            {
                var khedmatmapper = _mapper.Map<P_MahalKhedmat>(model);
                _context.MahalKhedmatManagerUW.Update(khedmatmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteMahalKhedmat(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var khedmat = _context.MahalKhedmatManagerUW.GetById(Id);
            if (khedmat == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteMahalKhedmat", khedmat);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMahalKhedmatPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.MahalKhedmatManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}