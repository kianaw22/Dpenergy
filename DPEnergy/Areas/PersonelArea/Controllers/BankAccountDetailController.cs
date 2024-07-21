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

namespace DPEnergy.Areas.PersonelArea
{
    
    [Area("PersonelArea")]
    [Authorize(Roles = "PersonelArea")]
    public class BankAccountDetailsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;

        public BankAccountDetailsController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.BankAccountDetailsUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddBankAccountDetails()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBankAccountDetails(P_BankAccountDetailsViewModel model,  string theexpirationdate)
        {
            FillCombo();
            model.CreationDate = DateTime.Now;
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (theexpirationdate != null)
            {
                model.ExpirationDate = ConvertDateTime.ConvertShamsiToMiladi(theexpirationdate);
            }

            if (ModelState.IsValid)
            {
               
                _context.BankAccountDetailsUW.Create(_mapper.Map<P_BankAccountDetails>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditBankAccountDetails(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            
            var comp = _context.BankAccountDetailsUW.GetById(Id);
            var mapcomp = _mapper.Map<P_BankAccountDetailsViewModel>(comp);
            return View(mapcomp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditBankAccountDetails(P_BankAccountDetailsViewModel model, string expirationdatee)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (expirationdatee != null)
            {
                model.ExpirationDate = ConvertDateTime.ConvertShamsiToMiladi(expirationdatee);
            }
            if (ModelState.IsValid)
            {
                var compmapper = _mapper.Map<P_BankAccountDetails>(model);
                _context.BankAccountDetailsUW.Update(compmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteBankAccountDetails(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.BankAccountDetailsUW.GetById(Id);
            if (city == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteBankAccountDetails", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBankAccountDetailsPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.BankAccountDetailsUW.DeleteById(Id);
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