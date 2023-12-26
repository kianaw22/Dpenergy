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
    public class DocumentTypeController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        public DocumentTypeController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _context = uow;
            _userManager = userManager;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.DocumentTypeManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddDocumentType()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDocumentType(D_DocumentTypeViewModel model)
        {
            FillCombo();
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            model.CreationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
               
                _context.DocumentTypeManagerUW.Create(_mapper.Map<D_DocumentType>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditDocumentType(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.DocumentTypeManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_DocumentTypeViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditDocumentType(D_DocumentTypeViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                var projmapper = _mapper.Map<D_DocumentType>(model);
                _context.DocumentTypeManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteDocumentType(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.DocumentTypeManagerUW.GetById(Id);
            if (proj == null)
            {
                var errorMessage = "No data found for the selected row id.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            return PartialView("_deleteDocumentType", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDocumentTypePost(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            _context.DocumentTypeManagerUW.DeleteById(Id);
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