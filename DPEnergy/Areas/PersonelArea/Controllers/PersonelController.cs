using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.CommonLayer.Services;
using DPEnergy.DataModelLayer;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers
{
    
    [Area("PersonelArea")]
    [Authorize(Roles = "PersonelArea")]
    public class PersonelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUploadFiles _upload;
        private readonly IUnitOfWork _context;
        private readonly UserManager<A_UserManager> _userManager;
        private readonly ApplicationDbContext _dbcontext;
        public PersonelController(IUploadFiles upload, IUnitOfWork uow, ApplicationDbContext dbcontext,
            IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _upload = upload;
            _context = uow;
            _mapper = mapper;
            _dbcontext = dbcontext;
        }
        public IActionResult UploadFile(IEnumerable<IFormFile> filearray, string path)
        {
            string filename = _upload.UploadFileFunc(filearray, path);
            return Json(new { status = "success", imagename = filename });
        }
        public void DeleteAttachment(string id)
        {
            if (id != null)
            {
                var record = _dbcontext.P_Personel.First(x => x.PersonelCode == id);
                if (!string.IsNullOrEmpty(record.MelliScanPath))
                {
                    
                    var path = "upload\\atachments\\Melliscan\\" + record.MelliScanPath;
                    var result = _upload.DeleteAttachmentByPersonelCode(path, "", "");
                    record.MelliScanPath = null;

                }
                if (!string.IsNullOrEmpty(record.ShenasnameScanPath))
                {
                   
                    var path = "upload\\atachments\\Shenasname-scan\\" + record.ShenasnameScanPath;
                   var result =  _upload.DeleteAttachmentByPersonelCode(path, "", "");
                    record.MelliScanPath = null;

                }
                if (!string.IsNullOrEmpty(record.PersonalImagePath))
                {
                    
                    var path = "upload\\personelimage\\" + record.PersonalImagePath;
                    var result = _upload.DeleteAttachmentByPersonelCode(path, "", "");
                    record.PersonalImagePath = null;

                }
                if (!string.IsNullOrEmpty(record.SignaturePath))
                {
                    
                    var path = "upload\\signatureimage\\" + record.SignaturePath;
                    var result =  _upload.DeleteAttachmentByPersonelCode(path, "", "");
                    record.SignaturePath = null;

                }
                _context.PersonelUW.Update(record);
                _context.save();
            }

        }
        public IActionResult Index()
        {
            var model = _context.PersonelUW.Get();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddPersonel()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPersonel(PersonelViewModel model, string birthdayDateuser, string newImagePathName, string newSignaturePathName, string newMelliPath,
            string newScanShenasnamePath , string tasfiehdate, string startofwork )
        {
            FillCombo();
            if (birthdayDateuser == null)
            {
                ModelState.AddModelError("BirthDate", "لطفا تاریخ تولد را وارد نمایید");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                
                //insert
                try
                {
                    
                    //کنترل تکراری نبودن نام کاربری
                    if ( _context.PersonelUW.GetById(model.PersonelCode) != null)
                    { 
                        ModelState.AddModelError("PersonelCode", "شماره پرسنلی تکراری می باشد.");
                        return View(model);
                    }
                    model.BirthDate = ConvertDateTime.ConvertShamsiToMiladi(birthdayDateuser);
                    if (tasfiehdate != null)
                    {
                        model.TasfieDate = ConvertDateTime.ConvertShamsiToMiladi(tasfiehdate);

                    }
                    if(startofwork !=null)
                    {
                        model.StartWorkDate = ConvertDateTime.ConvertShamsiToMiladi(startofwork);
                    }

                    model.Creator = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                    model.CreationDate = DateTime.Now;
                    model.PTasfieDate = tasfiehdate;
                    model.PBirthDate = birthdayDateuser;
                    model.PStartWorkDate = startofwork;
                    var personelMapped = (_mapper.Map<P_Personel>(model));  
                    personelMapped.SignaturePath = newSignaturePathName;
                    personelMapped.PersonalImagePath = newImagePathName;
                    personelMapped.MelliScanPath = newMelliPath;
                    personelMapped.ShenasnameScanPath = newScanShenasnamePath;
                    _context.PersonelUW.Create(personelMapped);
                    _context.save();
                    return RedirectToAction("Index");
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
        public IActionResult EditPersonel(string PersonelCode)
        {
         
            FillCombo();
            if (PersonelCode == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var personel = _context.PersonelUW.GetById(PersonelCode);
            var mappersonel = _mapper.Map<PersonelViewModel>(personel);
            var data = _context.PostManagerUW.Get().Where(x => x.PersonelCode == PersonelCode).ToList();
            ViewBag.posts = string.Join("-", data.Select(x => x.PostName));
            return View(mappersonel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPersonel(PersonelViewModel model, string birthdayDateuser, string newImagePathName, string newSignaturePathName, string newMelliPath,
            string newScanShenasnamePath , string tasfiehdate, string startofwork)
        {
            FillCombo();

          
            model.PTasfieDate = tasfiehdate;
            model.PBirthDate = birthdayDateuser;
            model.PStartWorkDate = startofwork;
            model.ModificationDate = DateTime.Now;
            model.Modifier = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
            var personelMapped = (_mapper.Map<P_Personel>(model));
            personelMapped.SignaturePath = newSignaturePathName;
            personelMapped.PersonalImagePath = newImagePathName;
            personelMapped.MelliScanPath = newMelliPath;
            personelMapped.ShenasnameScanPath = newScanShenasnamePath;
            
            if (ModelState.IsValid)
            {
                if (birthdayDateuser != null)
                {
                    personelMapped.BirthDate = ConvertDateTime.ConvertShamsiToMiladi(birthdayDateuser);
                }
               
                if (tasfiehdate != null)
                {
                    personelMapped.TasfieDate = ConvertDateTime.ConvertShamsiToMiladi(tasfiehdate);

                }
                if (startofwork != null)
                {
                    personelMapped.StartWorkDate = ConvertDateTime.ConvertShamsiToMiladi(startofwork);
                }

                //update

                _context.PersonelUW.Update(personelMapped);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeletePersonel(string PersonelCode)
        {
            if (PersonelCode == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var p = _context.PersonelUW.GetById(PersonelCode);
            if (p == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deletePersonel", p);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePersonelPost(string PersonelCode)
        {
            if (PersonelCode == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            DeleteAttachment(PersonelCode);
            _context.PersonelUW.DeleteById(PersonelCode);
            _context.save();
            return RedirectToAction("Index");

        }
        public void FillCombo()
        {
            List<P_City> ListCity = _context.CityManagerUW.Get().ToList();
            ViewBag.citylist = ListCity;
            List<P_Department> ListDepartment = _context.DepartmentManagerUW.Get().ToList();
            ViewBag.departmentlist = ListDepartment;
            List<P_Company> ListCompany = _context.CompanyManagerUW.Get().ToList();
            ViewBag.companylist = ListCompany;
            List<P_JobCategory> ListJobCategory = _context.JobCategoryManagerUW.Get().ToList();
            ViewBag.jobcategorylist = ListJobCategory;
            List<P_MahalKhedmat> ListMahalKhedmat = _context.MahalKhedmatManagerUW.Get().ToList();
            ViewBag.mahalkhedmatlist = ListMahalKhedmat;
            List<P_Post> ListPost = _context.PostManagerUW.Get().ToList();
            ViewBag.postlist = ListPost;
            List<P_WorkPlace> ListWorkPlace = _context.WorkPlaceManagerUW.Get().ToList();
            ViewBag.workplacelist = ListWorkPlace;

        }
    }
}