using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.CommonLayer.PublicClass;
using DPEnergy.CommonLayer.Services;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers
{
    [Area("PersonelArea")]
    public class PersonelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUploadFiles _upload;
        private readonly IUnitOfWork _context;
        public PersonelController(IUploadFiles upload, IUnitOfWork uow,  IMapper mapper)
        {
            _upload = upload;
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult UploadFile(IEnumerable<IFormFile> filearray, string path)
        {
            string filename = _upload.UploadFileFunc(filearray, path);
            return Json(new { status = "success", imagename = filename });
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
                    
                  
                    model.CreationDate = DateTime.Now;
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
            return View(mappersonel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPersonel(PersonelViewModel model, string birthdayDateuser, string newImagePathName, string newSignaturePathName, string newMelliPath,
            string newScanShenasnamePath , string tasfiehdate, string startofwork)
        {
            FillCombo();


            model.ModificationDate = DateTime.Now;
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