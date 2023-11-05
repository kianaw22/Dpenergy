using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.Services;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Entities.Reporrts;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Reports;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers
{
    [Area("DMSArea")]
    public class ReportsController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IWebHostEnvironment _hosting;
        private readonly IUploadFiles _upload;
        public ReportsController(IUploadFiles upload,IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager, IWebHostEnvironment hosting)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
            _hosting = hosting;
            _upload = upload;


            var stimulKey = Path.Combine(_hosting.ContentRootPath, "wwwroot\\reports\\license", "license.key");
            if (System.IO.File.Exists(stimulKey))
            {
                StiLicense.LoadFromFile(stimulKey);
            }
        }
        public IActionResult UploadReports(IEnumerable<IFormFile> filearray, string path , string projectcode)
        {
           
                if ( filearray.Count() == 0)
                {
                    return Json(new { status = "badsize"});

                }
          
            var filename = _upload.UploadReport(filearray, path, projectcode);
            if (filename == "-1")
            {
                return Json(new { status = "duplicate" });
            }

            return Json(new { status = "success", imagename = filename });

        }
        public IActionResult Index()
        {
            var model = _context.ReportsUW.Get(x => x.Area == "DMSArea");
            return View(model);
        }

        [HttpGet]
        public IActionResult AddReports()
        {
            FillCombo();
            return View();

        }
        [HttpPost]
        public IActionResult AddReports(ReportsViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                model.Area = "DMSArea";
                model.CreationDate = DateTime.Now;
                model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                var r = model.ReportPath.Replace("\\", "/"); ;
                int index = r.IndexOf("wwwroot");
                if (index != -1)
                {
                    model.ReportPath = r.Substring(index);
                   
                }
                _context.ReportsUW.Create(_mapper.Map<Reports>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditReports(String Id)
        {

            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }

            var rep = _context.ReportsUW.GetById(Id);
            ViewBag.name = Path.GetFileName(rep.ReportPath);

          
            var maprep = _mapper.Map<ReportsViewModel>(rep);
            return View(maprep);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditReports(ReportsViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                model.ModificationDate = DateTime.Now;
                model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                var projmapper = _mapper.Map<Reports>(model);
                _context.ReportsUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteReports(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.ReportsUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteReports", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteReportsPost(string Id)
        {
            var rep = _context.ReportsUW.GetById(Id);

            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            string path = rep.ReportPath;
            System.IO.File.Delete(path);
            _context.ReportsUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public IActionResult ReadReports(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }

            // var a = _context.ReportsManagerUW.GetById(ID);

            var model = _context.ReportsUW.Get(x => x.Id == Id).ToList()[0];

            StiReport report = new StiReport();
           
            report.Load(StiNetCoreHelper.MapPath(this,model.ReportPath));
            return StiNetCoreReportResponse.PrintAsPdf(report);

           
          
           
        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;

        }
    }
}