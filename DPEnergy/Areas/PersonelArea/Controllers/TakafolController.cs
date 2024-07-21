using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.CommonLayer.Services;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Personel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers
{
    
    [Area("PersonelArea")]
    [Authorize(Roles = "PersonelArea")]
    public class TakafolController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUploadFiles _upload;
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;
        public TakafolController(IUploadFiles upload, IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _upload = upload;
            _context = uow;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var model = _context.TakafolUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddTakafol()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTakafol(P_TakafolViewModel model, string birthdatee)
        {
            FillCombo();
            model.CreationDate = DateTime.Now;
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                if (birthdatee != null)
                {
                    model.Birthdate = ConvertDateTime.ConvertShamsiToMiladi(birthdatee);
                }
      
                _context.TakafolUW.Create(_mapper.Map<P_Takafol>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditTakafol(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var comp = _context.TakafolUW.GetById(Id);
            var mapcomp = _mapper.Map<P_TakafolViewModel>(comp);
            return View(mapcomp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTakafol(P_TakafolViewModel model, string birthdatee)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                if (birthdatee != null)
                {
                    model.Birthdate = ConvertDateTime.ConvertShamsiToMiladi(birthdatee);
                }
                var objmapper = _mapper.Map<P_Takafol>(model);
                _context.TakafolUW.Update(objmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteTakafol(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.TakafolUW.GetById(Id);
            if (city == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteTakafol", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTakafolPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.TakafolUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public IActionResult GetName(string personelcode)
        {
            var data = _context.PersonelUW.Get(x => x.PersonelCode == personelcode).ToList()[0];
            var Jsondata = new
            {

                Lastname = data.LastName,
                Firstname = data.FirstName,

            };

            return Json(Jsondata);

        }
        public void FillCombo()
        {

            List<P_Personel> ListPersonel = _context.PersonelUW.Get().ToList();
            ViewBag.personellist = ListPersonel;
        }
    }
}