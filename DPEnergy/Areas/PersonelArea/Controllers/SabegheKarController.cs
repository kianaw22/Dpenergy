﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.CommonLayer.Services;
using DPEnergy.DataModelLayer;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Personel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace DPEnergy.Areas.PersonelArea.Controllers
{
   
    [Area("PersonelArea")]
    [Authorize(Roles = "PersonelArea")]
    public class SabegheKarController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _context;
        private readonly ApplicationDbContext _dbcontext;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IUploadFiles _upload;
        public SabegheKarController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager, IUploadFiles upload, ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
            _upload = upload;
        }
        public IActionResult Index()
        {

            var model = _context.SabegheKarUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddSabegheKar()
        {
            FillCombo();
            return View();
        }
        public int FindCounter(string personelCode)
        {
            var sabegheKar = _dbcontext.P_SabegheKar.Where(e => e.PersonelCode == personelCode);
            if (sabegheKar.Any())
            {
                var maxCounter = sabegheKar.Max(e => e.Counter);
                return maxCounter+1;
            }
            return 1;
        }

        
        public IActionResult UploadAttachment(IEnumerable<IFormFile> filearray, string path , string personelcode, string extension)
        {
            var filename = personelcode + "-" + FindCounter(personelcode) + "." + extension;
            var result = _upload.UploadAttachmentByPersonelCode(filearray, path , personelcode,filename);
            if (result == "duplicate")
            {
               return Json(new { status = "duplicate" });
            }

            return Json(new { status = "success", mypath = result.Replace("\\", "/"), filename = filename });
            
        }
        public IActionResult UploadAttachmentEdit(IEnumerable<IFormFile> filearray, string path, string personelcode, string extension, string id)
        {
            var counter = _dbcontext.P_LetterRequest.First(x => x.Id == id).Counter;

            var filename = personelcode + "-" + counter + "." + extension;
            var result = _upload.UploadAttachmentByPersonelCode(filearray, path, personelcode, filename);
            if (result == "duplicate")
            {
                return Json(new { status = "duplicate" });
            }

            return Json(new { status = "success", mypath = result.Replace("\\", "/"), filename = filename });

        }
        public IActionResult DeleteAttachment(string path , string id)
        {
            if (id != null)
            {
                var record = _dbcontext.P_SabegheKar.First(x => x.Id == id);
                if (!string.IsNullOrEmpty(record.Attachment))
                {
                    record.Attachment = null;
                    _context.SabegheKarUW.Update(record);
                    _context.save();
                }
            }
            var result = _upload.DeleteAttachmentByPersonelCode(path, "","");
            if (result == false)
            {
                return Json(new { status = "nofile" });
            }

            return Json(new { status = "success" });

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSabegheKar(P_SabegheKarViewModel model, string startdatee, string enddatee)
        {
            FillCombo();
            model.CreationDate = DateTime.Now;
            model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            model.Counter = FindCounter(model.PersonelCode);
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

                _context.SabegheKarUW.Create(_mapper.Map<P_SabegheKar>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditSabegheKar(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                var errorMessage = "No id found for selected row.";
                return View("~/Views/Shared/Error.cshtml", errorMessage);
            }
            var comp = _context.SabegheKarUW.GetById(Id);
            var mapcomp = _mapper.Map<P_SabegheKarViewModel>(comp);
            return View(mapcomp);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSabegheKar(P_SabegheKarViewModel model, string startdatee, string enddatee)
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
                var compmapper = _mapper.Map<P_SabegheKar>(model);
                _context.SabegheKarUW.Update(compmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeleteSabegheKar(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var city = _context.SabegheKarUW.GetById(Id);
            if (city == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deleteSabegheKar", city);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSabegheKarPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var model = _context.SabegheKarUW.GetById(Id);
            DeleteAttachment(model.Attachment, null);
            _context.SabegheKarUW.DeleteById(Id);
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