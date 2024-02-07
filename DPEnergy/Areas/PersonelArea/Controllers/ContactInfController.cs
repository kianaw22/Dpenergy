
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Personel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers
{
    [Area("PersonelArea")]
    public class ContactInfController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;

        public ContactInfController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {

            var model = _context.ContactInfUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddContactInf()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddContactInf(P_ContactInfViewModel model)
        {
            FillCombo();
            model.CreationDate = DateTime.Now;
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                _context.ContactInfUW.Create(_mapper.Map<P_ContactInf>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditContactInf(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var comp = _context.ContactInfUW.GetById(Id);
            var mapcomp = _mapper.Map<P_ContactInfViewModel>(comp);
            return View(mapcomp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditContactInf(P_ContactInfViewModel model)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                var compmapper = _mapper.Map<P_ContactInf>(model);
                _context.ContactInfUW.Update(compmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteContactInf(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.ContactInfUW.GetById(Id);
            if (city == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteContactInf", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteContactInfPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.ContactInfUW.DeleteById(Id);
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