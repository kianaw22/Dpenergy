using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;




namespace DPEnergy.Areas.DMSArea.Controllers
{
    [Area("DMSArea")]
    [Authorize(Roles = "DMSArea")]
    public class ReportTestController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _hosting;

        public ReportTestController(IUnitOfWork uow, IMapper mapper, IWebHostEnvironment hosting)
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
           
            return View();
        }
        public IActionResult GetReport()

        {

            StiReport report = new StiReport();

            report.Load(StiNetCoreHelper.MapPath(this, "wwwroot/reports/DMSArea/7291/reportwithparam.mrt"));

            //report.Load(StiNetCoreHelper.MapPath(this, "Reports/Dashboard.mrt"));



            return StiNetCoreViewer.GetReportResult(this, report);

        }



        public IActionResult ViewerEvent()

        {

            return StiNetCoreViewer.ViewerEventResult(this);

        }
        public IActionResult ViewerInteraction()

        {

            // Some code before any interaction

            // ...



            return StiNetCoreViewer.InteractionResult(this);

        }
    }
}