using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers.BasicInf
{
    
    [Area("PersonelArea")]
    [Authorize]
    public class DepartmentController : Controller
    {

        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public DepartmentController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.DepartmentManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDepartment(DepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.DepartmentManagerUW.Create(_mapper.Map<P_Department>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditDepartment(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var dep = _context.DepartmentManagerUW.GetById(Id);
            var mapdep = _mapper.Map<DepartmentViewModel>(dep);
            return View(mapdep);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditDepartment(DepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var depmapper = _mapper.Map<P_Department>(model);
                _context.DepartmentManagerUW.Update(depmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteDepartment(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var dep = _context.DepartmentManagerUW.GetById(Id);
            if (dep == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteDepartment",dep);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteDepartmentPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.DepartmentManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }

    }
}
