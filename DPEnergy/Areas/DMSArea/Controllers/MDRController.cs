﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.ViewModels.DMS;
using DPEnergy.DataModelLayer.ViewModels.DMS.BasicInformation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers
{
    [Area("DMSArea")]
    public class MDRController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IWebHostEnvironment _hosting;
        public MDRController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager, IWebHostEnvironment hosting)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
            _hosting = hosting;

            var stimulKey = Path.Combine(_hosting.ContentRootPath, "wwwroot\\reports\\license", "license.key");
            if (System.IO.File.Exists(stimulKey))
            {
                StiLicense.LoadFromFile(stimulKey);
            }
        }
        public IActionResult Index()
        {
            var model = _context.MDRManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult SetProject()
        {
            FillCombo();
            var userid = _userManager.GetUserId(HttpContext.User);
            List<D_UserProject> ListProject = _context.UserProjectUW.Get(x=> x.UserId == userid).ToList();
            ViewBag.projectlist = ListProject;
            return PartialView("_setProject");
        }
        [HttpGet]
        public IActionResult AddMDR(string ProjectID)
        {
            FillCombo();

   
            var projcode = _context.projectManagerUW.GetById(ProjectID).ProjectCode;
            var projtitle = _context.projectManagerUW.GetById(ProjectID).Title;
            FillMDRCombo(projcode);
                var model = new D_MDRViewModel
                {
                    ProjectTitle = projtitle,
                    ProjectCode = projcode,
                };
                var mapproj = _mapper.Map<D_MDRViewModel>(model);
            return View(model);     
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddMDR(D_MDRViewModel model)
        {

         
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                model.CreationDate = DateTime.Now;
                model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                _context.MDRManagerUW.Create(_mapper.Map<D_MDR>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            FillMDRCombo(model.ProjectCode);
            FillCombo();
            return View(model);
        }
        [HttpGet]
        public IActionResult EditMDR(String Id)
        {
           
            FillCombo();
           

            if (Id == null)
            {
                var errorMessage = "No id found for selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage); 
            }
            
            var proj = _context.MDRManagerUW.GetById(Id);
            FillMDRCombo(proj.ProjectCode);
            var projtitle = _context.projectManagerUW.Get().Where(x => x.ProjectCode == proj.ProjectCode).ToList()[0].Title;
            var mapproj = _mapper.Map<D_MDRViewModel>(proj);
            mapproj.ProjectTitle = projtitle;
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMDR(D_MDRViewModel model)
        {
            FillCombo();
            FillMDRCombo(model.ProjectCode);
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                JsonHelper.SanitizeStringProperties(model);
                var projmapper = _mapper.Map<D_MDR>(model);
                _context.MDRManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteMDR(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row to delete.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var proj = _context.MDRManagerUW.GetById(Id);
            var rev = _context.RevisionUW.Get(x => x.ProjectCode == proj.ProjectCode && x.ClientNumber == proj.ClientNumber);
            if (rev.Count()!= 0 )
            {
                return Json("bad");
            }
            if (proj == null)
            {
                var errorMessage = "No project found for the selected id.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            return PartialView("_deleteMDR", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMDRPost(string Id)
        {
            if (Id == null)
            {
                var errorMessage = "No id found for the selected row to delete.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            _context.MDRManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public IActionResult ReadMDR( string ID  )
        {
            if (ID==null)
            {
                return RedirectToAction("ErrorView", "Home");
            }

            var model = _context.MDRManagerUW.Get(x => x.Id == ID).ToList()[0]; 
            StiReport report = new StiReport();
            report["ClientNumber"] = model.ClientNumber;
            report.Load(StiNetCoreHelper.MapPath(this, "wwwroot/reports/mdr.mrt"));
            return StiNetCoreReportResponse.ResponseAsExcel2007(report);
        }
        public void FillCombo()
        {
          
            List<D_Phase> ListPhase = _context.PhaseManagerUW.Get().ToList();
            ViewBag.phaselist = ListPhase;

            List<D_DocumentType> ListDType = _context.DocumentTypeManagerUW.Get().ToList();
            ViewBag.dtype = ListDType;

            List<D_DpDicipline> ListDpDicipline = _context.DpDiciplineManagerUW.Get().ToList();
            ViewBag.dpdicipline = ListDpDicipline;

        }
        public void FillMDRCombo(string projcode)
        {
            List<D_Unit> ListUnit = _context.UnitManagerUW.Get().Where(x => x.ProjectCode == projcode).ToList();
            ViewBag.listunit = ListUnit;
            List<D_ClientDicipline> ListClientDicipline = _context.ClientDiciplineManagerUW.Get().Where(x => x.ProjectCode == projcode).ToList();
            ViewBag.listclientdicipline = ListClientDicipline;
            List<D_Classification> ListClass = _context.ClassificationManagerUW.Get().Where(x => x.Project == projcode).ToList();
            ViewBag.listclass = ListClass;
            List<D_AdditionalWork> ListAddW = _context.AdditionalWorkManagerUW.Get().Where(x => x.ProjectCode == projcode).ToList();
            ViewBag.listaddw = ListAddW;
        }
    }
}