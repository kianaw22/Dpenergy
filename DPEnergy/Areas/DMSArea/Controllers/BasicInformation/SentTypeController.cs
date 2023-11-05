using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    public class SentTypeController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public SentTypeController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.SentTypeManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddSentType()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSentType(D_SentTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreationDate = DateTime.Now;
                _context.SentTypeManagerUW.Create(_mapper.Map<D_SentType>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditSentType(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.SentTypeManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_SentTypeViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSentType(D_SentTypeViewModel model)
        {
            model.ModificationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_SentType>(model);
                _context.SentTypeManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteSentType(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.SentTypeManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteSentType", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSentTypePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.SentTypeManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}