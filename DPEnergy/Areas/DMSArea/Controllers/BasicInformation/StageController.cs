﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    public class StageController : Controller
    {
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public StageController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.StageManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddStage()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStage(D_StageViewModel model)

        {
            FillCombo();
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            model.CreationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);

                _context.StageManagerUW.Create(_mapper.Map<D_Stage>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditStage(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.StageManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_StageViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditStage(D_StageViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                var projmapper = _mapper.Map<D_Stage>(model);
                _context.StageManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteStage(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.StageManagerUW.GetById(Id);
            if (proj == null)
            {
                var errorMessage = "No data found for the selected row id.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            return PartialView("_deleteStage", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStagePost(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            _context.StageManagerUW.DeleteById(Id);
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