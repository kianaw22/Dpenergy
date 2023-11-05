using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DPEnergy.DataModelLayer.ViewModels;
using DPEnergy.DataModelLayer.Entities;

namespace DPEnergy.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class AccessRightController : Controller
    {
        //دارای یک نکته مهم
        private readonly IUnitOfWork _context;
        private readonly IRoleRepository _Irr;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly RoleManager<ApplicationRoles> _roleManager;
        private readonly IAccessRepository _getname;

        public AccessRightController(IUnitOfWork context,
                                    UserManager<A_UserManager> userManager,
                                    RoleManager<ApplicationRoles> roleManager,
                                    IRoleRepository irr,
                                    IAccessRepository getname)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _Irr = irr;
            _getname = getname;
        }

        public IActionResult Index()
        {
            var model = _getname.GetNameFromPersonelCode(); 
            return View(model);
        }

        [HttpGet]
        public IActionResult AddRoleToUser( string id , string firstname , string lastname)
        {
            FillTreeView();
            ViewBag.FullName = firstname + " " + lastname;
            ViewBag.userId = id;
            ViewBag.userRole = _Irr.GetRoleId(id);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(string selectedItems, string userId)
        {
            try
            {
                //تبدیل رشته جیسون به یک لیست
                List<TreeViewModel> items = JsonConvert.DeserializeObject<List<TreeViewModel>>(selectedItems);
                if (items.Count() == 0)
                {
                    return Json(new { status = "noselected" });
                }

                //پیدا کردن کاربر
                var user = await _userManager.FindByIdAsync(userId);

                //پیدا کردن همه نقش های کاربر
                var roles = await _userManager.GetRolesAsync(user);
                //حذف همه دسترسی های قبلی کاربر
                IdentityResult deleteAllrole = await _userManager.RemoveFromRolesAsync(user, roles);


                if (deleteAllrole.Succeeded)
                {
                    //ثبت دسترسی های جدید به کاربر
                    for (int i = 0; i <= items.Count - 1; i++)
                    {
                        ApplicationRoles approle = await _roleManager.FindByIdAsync(items[i].id);
                        if (approle != null)
                        {
                            await _userManager.AddToRoleAsync(user, approle.Name);
                        }
                    }
                }
                return Json(new { status = "success" });

            }
            catch
            {
                return RedirectToAction("ErrorView", "Home");
            }

        }
        private void FillTreeView()
        {
            List<TreeViewModel> node = new List<TreeViewModel>();

            node.Add(new TreeViewModel
            {
                id = "1",
                text = "حقوق دسترسی",
                parent = "#"
            });

            foreach (ApplicationRoles role in _context.RoleManagerUW.Get(r => r.RoleLevel != "0"))
            {
                node.Add(new TreeViewModel
                {
                    id = role.Id.ToString(),
                    parent = role.RoleLevel.ToString(),
                    text = role.Description
                });
            }

            ViewBag.AccessRight = JsonConvert.SerializeObject(node);
        }

       

       
    }
}