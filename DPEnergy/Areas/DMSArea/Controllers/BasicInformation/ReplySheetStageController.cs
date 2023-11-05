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
    public class ReplySheetStageController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public ReplySheetStageController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.ReplySheetStageManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddReplySheetStage()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddReplySheetStage(D_ReplySheetStageViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreationDate = DateTime.Now;
                _context.ReplySheetStageManagerUW.Create(_mapper.Map<D_ReplySheetStage>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditReplySheetStage(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ReplySheetStageManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_ReplySheetStageViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditReplySheetStage(D_ReplySheetStageViewModel model)
        {
            model.ModificationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_ReplySheetStage>(model);
                _context.ReplySheetStageManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteReplySheetStage(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ReplySheetStageManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteReplySheetStage", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteReplySheetStagePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.ReplySheetStageManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;

        }
    }
}