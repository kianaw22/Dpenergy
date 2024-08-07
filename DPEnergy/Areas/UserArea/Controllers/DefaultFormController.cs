﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.UserArea.Controllers
{

    [Area("UserArea")]
    public class DefaultFormController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        public DefaultFormController(IUnitOfWork context,
                                       UserManager<A_UserManager> userManager,
                                                IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(_context.AdministrativeFormUW.Get(ad => ad.UserID == _userManager.GetUserId(HttpContext.User) && ad.AdministrativeFormType == false));
        }
        [HttpGet]
        public IActionResult AddNewDefaultForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNewDefaultForm(A_AdministrativeFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.UserID = _userManager.GetUserId(HttpContext.User);
                model.AdministrativeFormType = false;
                _context.AdministrativeFormUW.Create(_mapper.Map<A_AdministrativeForm>(model));
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int AdministrativeFormID)
        {
            if (AdministrativeFormID == 0)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var model = _context.AdministrativeFormUW.GetById(AdministrativeFormID);
            if (model == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteform", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteForm(int AdministrativeFormID)
        {
            if (AdministrativeFormID == 0)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            try
            {
                _context.AdministrativeFormUW.DeleteById(AdministrativeFormID);
                _context.save();
                return RedirectToAction("Index");
            }
            catch
            {

                return RedirectToAction("ErrorView", "Home");
            }
        }
    }
}