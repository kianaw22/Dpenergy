using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DPEnergy.DataModelLayer.Entities.DMS.Stackholders;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.CommonLayer.Services;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.Admin;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore.Internal;
using DPEnergy.DataModelLayer.ViewModels.User;
using DPEnergy.DataModelLayer.Entities.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace DPEnergy.Areas.UserArea.Controllers
{
    [Authorize]
    [Area("UserArea")]
  
    public class ExternalLetterController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly IUploadFiles _upload;
        private readonly IMapper _mapper;
        
        public ExternalLetterController(IUnitOfWork db,IUploadFiles upload,IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _context = db;
            _userManager = userManager;
            _upload = upload;
            _mapper = mapper;
        }
        
        
        public IActionResult UploadAttachFile(IEnumerable<IFormFile> filearray, string path)
        {
            var totalsize = 0.0;
            foreach ( var item in filearray)
            {
                totalsize += item.Length;
            }
            if (totalsize > 10000000)
            {
                return Json(new { status = "badsize" });
            }
            var user = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User));

            var filename = _upload.UploadMultiAttachment(filearray, path, user.UserName);

            return Json(new { status = "success", imagename = filename });
           
        }
        
        

        public IActionResult CreateLetter()
        {
            FillCombo();
            
            return View();
           
        }
       
        
        [HttpPost]
        public IActionResult CreateLetter(ExternalLettersViewModel model, string newfilePathName)
        {
            
            FillCombo();
            if (ModelState.IsValid)
            {
                //Check Recipent 
                model.Recipent = model.Recipent.Distinct().ToList();
                //insert
                var letter = new U_ExternalLetters
                {
                    LetterSubject = model.LetterSubject,
                    UserID = _userManager.GetUserId(HttpContext.User),
                    LetterCreateDate = DateTime.Now,
                    LetterContent =  model.LetterContent

                };
                _context.ExternalLettersUW.Create(letter);
                _context.save();
                var PK = letter.LetterID;
                
                

                foreach (var items in model.Recipent)
                {
                    var it = items.Split("-");

                    
                     U_LetterRecipents R = new U_LetterRecipents
                     {
                         LetterID = PK,
                         Company = it[0],
                         Person = it[1],
                         Position = it[2]
                     };
                     _context.LetterRecipentsUW.Create(R);
                     _context.save();
                    
                }
                var paths = newfilePathName.Split(",");
                foreach ( var item in paths)
                {
                    U_ExLetterAttachments A = new U_ExLetterAttachments
                    {
                        LetterID = PK,
                        Attachment = item
                    };
                    _context.LetterAttachmentsUW.Create(A);
                    _context.save();
                }
                
            }
           
            return View(model);
        }

        [HttpGet]
        public IActionResult AutomationFormList()
        {
            var model = _context.AdministrativeFormUW.Get(a => a.AdministrativeFormType == true).ToList();
            return PartialView("_automationFormList", model);
        }

        [HttpGet]
        public IActionResult DefaultFormList()
        {
            var model = _context.AdministrativeFormUW.Get(a => a.AdministrativeFormType == false && a.UserID == _userManager.GetUserId(HttpContext.User)).ToList();
            return PartialView("_defaultFormList", model);
        }
        public void FillCombo()
        {
            List<D_ProjectMembers> ListProjectMembers = _context.ProjectMembersUW.Get().GroupBy(x => new { x.Company, x.Person }).Select(x => x.First()).ToList();
            List<D_ProjectMembers> ListProjectCompany = _context.ProjectMembersUW.Get().GroupBy(x => x.Company).Select(x => x.First()).ToList();
            List<D_ProjectMembers> ListProjectPosition = _context.ProjectMembersUW.Get().ToList();
            ViewBag.projectmembers = JsonConvert.SerializeObject(ListProjectMembers);
            ViewBag.projectcompany = JsonConvert.SerializeObject(ListProjectCompany);
            ViewBag.projectposition = JsonConvert.SerializeObject(ListProjectPosition);
        }
    }
    
}