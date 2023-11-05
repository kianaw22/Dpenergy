
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Entities.DMS.Stackholders;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS.Stackholders;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers.Stackholders
{
    
    [Area("DMSArea")]
    public class PositionController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        public PositionController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _context = uow;
            _mapper = mapper;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var model = _context.PositionManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddPosition()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPosition(D_PositionViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreationDate = DateTime.Now;
                model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                _context.PositionManagerUW.Create(_mapper.Map<D_Position>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditPosition(String Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.PositionManagerUW.GetById(Id);
            var mapproj = _mapper.Map<D_PositionViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPosition(D_PositionViewModel model)
        {
            model.ModificationDate = DateTime.Now;
            
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<D_Position>(model);
                _context.PositionManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeletePosition(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.PositionManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deletePosition", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePositionPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.PositionManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        
    }
}