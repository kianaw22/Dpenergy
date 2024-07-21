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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.DMSArea.Controllers
{
    
    [Area("PersonelArea")]
    [Authorize(Roles = "PersonelArea")]
    public class VaziatKhedmatController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IUploadFiles _upload;
        public VaziatKhedmatController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager, IUploadFiles upload)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
            _upload = upload;
        }
        public IActionResult Index()
        {

            var model = _context.VaziatKhedmatUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddVaziatKhedmat()
        {
            FillCombo();
            return View();
        }
        public IActionResult UploadNezamAttach(IEnumerable<IFormFile> filearray, string path , string name)
        {
            var result = _upload.UploadNezamvazife(filearray, path, name);
            if (result.Item1 == true)
            {
                return Json(new { status = "duplicate" });
            }

            return Json(new { status = "success", mypath = result.Item2.Replace("\\", "/") });

        }
        public IActionResult DeleteNezamAttach( string path, string name)
        {
            var result = _upload.DeleteNezamVazife(path, name);
            if (result == false)
            {
                return Json(new { status = "nofile" });
            }

            return Json(new { status = "success" });

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddVaziatKhedmat(P_VaziatKhedmatViewModel model , string startdatee , string enddatee)
        {
            FillCombo();
            model.CreationDate = DateTime.Now;
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                if (startdatee!= null)
                {
                    model.StartDate = ConvertDateTime.ConvertShamsiToMiladi(startdatee);
                }
                if (enddatee != null)
                {
                    model.EndDate = ConvertDateTime.ConvertShamsiToMiladi(enddatee);
                }
               
                _context.VaziatKhedmatUW.Create(_mapper.Map<P_VaziatKhedmat>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditVaziatKhedmat(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var comp = _context.VaziatKhedmatUW.GetById(Id);
            var mapcomp = _mapper.Map<P_VaziatKhedmatViewModel>(comp);
            return View(mapcomp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditVaziatKhedmat(P_VaziatKhedmatViewModel model , string startdatee, string enddatee)
        {
            FillCombo();
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            if (ModelState.IsValid)
            {
                if (startdatee != null)
                {
                    model.StartDate = ConvertDateTime.ConvertShamsiToMiladi(startdatee);
                }
                if (enddatee != null)
                {
                    model.EndDate = ConvertDateTime.ConvertShamsiToMiladi(enddatee);
                }
                var compmapper = _mapper.Map<P_VaziatKhedmat>(model);
                _context.VaziatKhedmatUW.Update(compmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteVaziatKhedmat(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.VaziatKhedmatUW.GetById(Id);
            if (city == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteVaziatKhedmat", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteVaziatKhedmatPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var obj = _context.VaziatKhedmatUW.GetById(Id);
            _upload.DeleteFile(obj.Attachment,"","");
            _context.VaziatKhedmatUW.DeleteById(Id);
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