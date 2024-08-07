﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    [Authorize(Roles = "DMSArea")]
    public class ProjectTypeController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public ProjectTypeController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.ProjectTypeManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddProjectType()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProjectType(D_ProjectTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                _context.ProjectTypeManagerUW.Create(_mapper.Map<D_ProjectType>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditProjectType(String Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.ProjectTypeManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_ProjectTypeViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProjectType(D_ProjectTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                var projmapper = _mapper.Map<D_ProjectType>(model);
                _context.ProjectTypeManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteProjectType(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.ProjectTypeManagerUW.GetById(Id);
            if (proj == null)
            {
                var errorMessage = "No data found for the selected row id.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            return PartialView("_deleteProjectType", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProjectTypePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.ProjectTypeManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}