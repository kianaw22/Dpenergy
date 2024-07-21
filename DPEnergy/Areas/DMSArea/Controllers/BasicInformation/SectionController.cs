﻿using System;
using System;
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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Sections.DMSSection.Controllers.BasicInformation
{
    [Area("DMSArea")]
    [Authorize(Roles = "DMSArea")]
    public class SectionController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        public SectionController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.SectionManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddSection()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSection(D_SectionViewModel model)
        {
            FillCombo();
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            model.CreationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                _context.SectionManagerUW.Create(_mapper.Map<D_Section>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditSection(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.SectionManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_SectionViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSection(D_SectionViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                var projmapper = _mapper.Map<D_Section>(model);
                _context.SectionManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteSection(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.SectionManagerUW.GetById(Id);
            if (proj == null)
            {
                var errorMessage = "No data found for the selected row id.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            return PartialView("_deleteSection", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSectionPost(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            _context.SectionManagerUW.DeleteById(Id);
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