using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
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
    public class BimeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;

        public BimeController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {

            var model = _context.BimeUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddBime()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBime(P_BimeViewModel model , string tarikhtamin ,string tarikhkhodezhari)
        {
            FillCombo();
            model.CreationDate = DateTime.Now;
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                if (tarikhtamin != null)
                {
                    model.TarikhSabtSabegheTamin = ConvertDateTime.ConvertShamsiToMiladi(tarikhtamin);
                }
                if (tarikhkhodezhari!= null)
                {
                    model.TarikhSabtKhodEzhari = ConvertDateTime.ConvertShamsiToMiladi(tarikhkhodezhari);
                }
          
              
                _context.BimeUW.Create(_mapper.Map<P_Bime>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditBime(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var comp = _context.BimeUW.GetById(Id);
            var mapcomp = _mapper.Map<P_BimeViewModel>(comp);
            return View(mapcomp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditBime(P_BimeViewModel model, string tarikhtamin, string tarikhkhodezhari)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                if (tarikhtamin != null)
                {
                    model.TarikhSabtSabegheTamin = ConvertDateTime.ConvertShamsiToMiladi(tarikhtamin);
                }
                if (tarikhkhodezhari != null)
                {
                    model.TarikhSabtKhodEzhari = ConvertDateTime.ConvertShamsiToMiladi(tarikhkhodezhari);
                }
                var compmapper = _mapper.Map<P_Bime>(model);
                _context.BimeUW.Update(compmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteBime(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.BimeUW.GetById(Id);
            if (city == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteBime", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBimePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.BimeUW.DeleteById(Id);
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