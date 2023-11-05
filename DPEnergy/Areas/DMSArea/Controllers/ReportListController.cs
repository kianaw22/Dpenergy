using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers
{
    [Area("DMSArea")]
    public class ReportListController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hosting;

        public ReportListController(IUnitOfWork uow, IMapper mapper, IWebHostEnvironment hosting)
        {
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
            var model = _context.ReportsUW.Get().Where(x => x.Area == "DMSArea")
            .Select(x => new D_ReportListViewModel
            {
                Id = x.Id,
                ReportName = x.ReportName,
                ProjectCode = x.ProjectCode,
                Description = x.Description,
                ReportPath = x.ReportPath,
                FileName = Path.GetFileName(x.ReportPath)
            })
         .ToList();

            return View(model);
        }
        public IActionResult ReadReports(string reportpath)
        {
            string fullPath = $"{Request.PathBase}/{reportpath}";
            StiReport report = new StiReport();

            report.Load(StiNetCoreHelper.MapPath(this, fullPath));
            return StiNetCoreReportResponse.PrintAsHtml(report);
        }
        public IActionResult ViewReportsPage(string reportpath)
        {
            //ViewBag.path = reportpath;
            return View();
        }
        public IActionResult ViewReports( string reportpath)
        {
            StiReport report = new StiReport();

            report.Load(StiNetCoreHelper.MapPath(this, reportpath));
            return StiNetCoreViewer.GetReportResult(this, report);
        }
        public IActionResult ViewerEvent()
        {
            return StiNetCoreViewer.ViewerEventResult(this);
        }
        public IActionResult ViewerInteraction()
        {
            return StiNetCoreViewer.InteractionResult(this);

        }

    }
}