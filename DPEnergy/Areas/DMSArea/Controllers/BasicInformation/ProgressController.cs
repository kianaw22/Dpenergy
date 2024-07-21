﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.DataModelLayer;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.BasicInformation
{
    [Area("DMSArea")]
    [Authorize(Roles = "DMSArea")]
    public class ProgressController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _dbcontext;
        public ProgressController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager, ApplicationDbContext dbcontext)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            
           var model = _context.ProgressManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddProgress()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProgress(D_ProgressViewModel model)
        {
            FillCombo();
            if (_dbcontext.D_Progress.Any(c => c.Stage == model.Stage && c.ProjectCode == model.ProjectCode))
            {
                ModelState.AddModelError("Stage", "stage already exists for this project.");

            }
            model.CreationDate = DateTime.Now;
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                
                _context.ProgressManagerUW.Create(_mapper.Map<D_Progress>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditProgress(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.ProgressManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_ProgressViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditProgress(D_ProgressViewModel model)
        {
            FillCombo();
             
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                model.CreationDate = DateTime.Now;
                var projmapper = _mapper.Map<D_Progress>(model);
                _context.ProgressManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteProgress(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.ProgressManagerUW.GetById(Id);
            if (proj == null)
            {
                var errorMessage = "No data found for the selected row id.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            return PartialView("_deleteProgress", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProgressPost(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            _context.ProgressManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
            List<D_Stage> ListStage = _context.StageManagerUW.Get().ToList();
            ViewBag.stagelist = ListStage;
        }
    }
}