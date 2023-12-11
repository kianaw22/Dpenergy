using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize]
    public class UserManagerController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        public UserManagerController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _context = uow;
            _mapper = mapper;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var model = _context.UserManagerManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddUser(A_UserManagerViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                //insert
                try
                {
                    
                    //کنترل تکراری نبودن نام کاربری
                    if (await _userManager.FindByNameAsync(model.UserName) != null)
                    {
                        ModelState.AddModelError("UserName", "نام کاربری تکراری می باشد.");
                        return View(model);
                    }
                  
                    var userMapped = _mapper.Map<A_UserManager>(model);
                    IdentityResult result = await _userManager.CreateAsync(userMapped, userMapped.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
                catch
                {
                    //throw;
                    return RedirectToAction("ErrorView", "Home");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditUser(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.UserManagerManagerUW.GetById(Id);
            var mapproj = _mapper.Map<A_UserManagerViewModel>(proj);
            return View(mapproj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUser(A_UserManagerViewModel model)
        {
            FillCombo();
            
            if (ModelState.IsValid)
            {
                var projmapper = _mapper.Map<A_UserManager>(model);
                _context.UserManagerManagerUW.Update(projmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteUser(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var proj = _context.UserManagerManagerUW.GetById(Id);
            if (proj == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteUser", proj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUserPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.UserManagerManagerUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<P_Personel> ListPersonel = _context.PersonelUW.Get().ToList();
            ViewBag.personellist = ListPersonel;
        }
    }
}