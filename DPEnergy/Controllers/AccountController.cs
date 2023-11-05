using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.ViewModels.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<A_UserManager> _signInManager;
        private readonly UserManager<A_UserManager> _userManager;

        public AccountController(SignInManager<A_UserManager> signInManager, UserManager<A_UserManager>userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/UserArea/UserHome/Index");
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, true, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    
                    var user = await _userManager.FindByNameAsync(model.UserName);
     
                    if (user.IsAdmin == 1)
                    {
                        return Redirect("/UserArea/UserHome/Index");
                    }
                    else
                    {
                        return Redirect("/UserArea/UserHome/Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("Password", "اطلاعات ورود صحیح نیست");
                    return View(model);
                }
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Account/Login");
        }

    }
}