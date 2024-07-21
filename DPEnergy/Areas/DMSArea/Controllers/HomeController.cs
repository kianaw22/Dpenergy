using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers
{
    [Area("DMSArea")]
    [Authorize(Roles = "DMSArea")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _context;
        public HomeController(IUnitOfWork uow)
        {
            _context = uow;
        }
        public IActionResult Index()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
            var model = _context.MDRManagerUW.Get(x => x.ProjectCode == "7291");
            return View(model);
        }
    }
}