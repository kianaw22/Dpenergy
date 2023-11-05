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
    public class WorkPlaceController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public WorkPlaceController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.WorkPlaceManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddWorkPlace()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddWorkPlace(P_WorkPlaceViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.WorkPlaceManagerUW.Create(_mapper.Map<P_WorkPlace>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditWorkPlace(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.WorkPlaceManagerUW.GetById(Id);
            var mapwp = _mapper.Map<P_WorkPlaceViewModel>(wp);
            return View(mapwp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditWorkPlace(P_WorkPlaceViewModel model)
        {
            if (ModelState.IsValid)
            {
                var wpmapper = _mapper.Map<P_WorkPlace>(model);
                _context.WorkPlaceManagerUW.Update(wpmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteWorkPlace(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.WorkPlaceManagerUW.GetById(Id);
            if (wp == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteWorkPlace", wp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteWorkPlacePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.WorkPlaceManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}