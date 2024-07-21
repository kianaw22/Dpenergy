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
    public class CityController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        
        public CityController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.CityManagerUW.Get();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCity()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCity(P_CityViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.CityManagerUW.Create(_mapper.Map<P_City>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditCity(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.CityManagerUW.GetById(Id);
            var mapcity = _mapper.Map<P_CityViewModel>(city);
            return View(mapcity);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCity(P_CityViewModel model)
        {
            if (ModelState.IsValid)
            {
                var citymapper = _mapper.Map<P_City>(model);
                _context.CityManagerUW.Update(citymapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteCity(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.CityManagerUW.GetById(Id);
            if ( city==null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deletCity", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCityPost(string Id )                             
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.CityManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}