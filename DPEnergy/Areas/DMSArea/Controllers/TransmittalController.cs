using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.Admin;
using DPEnergy.DataModelLayer.Entities.DMS;
using DPEnergy.DataModelLayer.Entities.DMS.BasicInformation;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.DMS;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DPEnergy.Areas.DMSArea.Controllers
{
    [Area("DMSArea")]
    public class TransmittalController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        private readonly UserManager<A_UserManager> _userManager;
        public TransmittalController(IUnitOfWork uow, IMapper mapper, UserManager<A_UserManager> userManager)
        {
            _userManager = userManager;
            _context = uow;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult AddTransmittal(string ProjectID)
        {
            FillCombo();
            if (ProjectID != null )
            {
                var projcode = _context.projectManagerUW.GetById(ProjectID).ProjectCode;

                var model = new D_RevisionViewModel
                {
                    ProjectCode = projcode,
                };

                return View(model);
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTransmittal(D_RevisionViewModel model, string buttonId, string checkedItems)
        {
            if (buttonId == "Cancel")
            {
                return RedirectToAction("Index");
            }
            var checkedItemsList = JsonConvert.DeserializeObject<List<D_RevisionViewModel>>(checkedItems);
           
            if (ModelState.IsValid)
            {

                foreach (var item in checkedItemsList)
                {
                    var modelrev = _context.RevisionUW.GetById(item.Id);
                    modelrev.TransmittalNumber = model.TransmittalNumber;
                    modelrev.TransmittalDate = model.TransmittalDate;
                    modelrev.NumberofCopies = model.NumberofCopies;
                    modelrev.TransmittalCreatedBy = _context.UserManagerUW.GetById(_userManager.GetUserId(HttpContext.User)).ToString();
                    modelrev.RemarksTransmittal = model.RemarksTransmittal;
                    modelrev.IssuedBy = model.IssuedBy;
                    modelrev.Client = model.Client;
                    modelrev.Reciever = model.Reciever;
                    List<string> senttype = new List<string>();
                    if (model.CD) { senttype.Add("CD"); }
                    if (model.Email) { senttype.Add("Email"); }
                    if (model.File) { senttype.Add("File"); }
                    if (model.Original) { senttype.Add("Original"); }
                    if (model.Other) { senttype.Add("Other"); }
                    if (model.Print) { senttype.Add("Print"); }
                    modelrev.SentType = string.Join(", ", senttype);
                    var mapp = _mapper.Map<D_Revision>(modelrev);
                    _context.RevisionUW.Update(mapp);
                    _context.save();
                }
               

                if (buttonId == "Save")
                {
                    return RedirectToAction("Index","Revision");
                }
                else if (buttonId == "Append")
                {
                    var PID = _context.projectManagerUW.Get(x => x.ProjectCode == model.ProjectCode).ToList()[0].Id;
                    return RedirectToAction("AddTransmittal", new { ProjectID = PID });
                }

            }
            return View(model);
     
        }
        public IActionResult FilterDataGrid (string projectcode)
        {
            var model = _context.RevisionUW.Get(x => x.ProjectCode == projectcode && x.TransmittalNumber == null );
            return Json(model);
        }
        [HttpGet]
        public IActionResult GetFields(string projectcode)
        {
            if (projectcode == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }

            var data = _context.projectManagerUW.Get(x => x.ProjectCode == projectcode).ToList()[0];
            var consultant = data.Company;
            var client = data.Contractor;
            var issuedby = data.ProjectManager;
            var reciever = data.ContractorName;
           

            var a = new
            {
                Consultant = consultant,
                Client = client,
                Issuedby = issuedby,
                Reciever = reciever,
               

            };

            return Json(a);
        }
        [HttpGet]
        public IActionResult DeleteTransmittal()
        {
            FillCombo();
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTransmittal(string TransmittalNumber, string buttonId)
        {
            if (buttonId == "Cancel")
            {
                return RedirectToAction("Index");
            }
            var data = _context.RevisionUW.Get(x => x.TransmittalNumber == TransmittalNumber).ToList();
            foreach ( var item in data)
            {
                item.TransmittalCreatedBy = null;
                item.TransmittalNumber = null;
                item.TransmittalDate=null;
                item.NumberofCopies = null;
                item.RemarksTransmittal = null;
                item.IssuedBy = null;
                item.Client = null;
                item.Reciever = null;
                item.CD = false;
                item.Email = false;
                item.File = false;
                item.Original = false;
                item.Other = false;
                item.Print = false;

                var mapp = _mapper.Map<D_Revision>(item);
                _context.RevisionUW.Update(mapp);
                _context.save();
            }
            if (buttonId == "Delete")
            {
                return RedirectToAction("Index", "Revision");
            }
            FillCombo();
            return View();
        }
        /*
        public IActionResult FillTransNumberCombo(string projectcode)
        {
            List<D_Revision> ListTrans = _context.RevisionUW.Get();
            if (ListTrans != null)
            {
                return Json(ListTrans.ToList());
            }

            return Json()
        }
        */
        public IActionResult GetTransCombo(string projectcode)
        {
            var data = _context.RevisionUW.Get(x => x.ProjectCode == projectcode && x.TransmittalNumber != null).Select(r => new { Transnumber = r.TransmittalNumber }).Distinct().ToList() ;

            return Json(data);
        }
        public IActionResult FilterTransGrid(string transnumber)
        {
            var data = _context.RevisionUW.Get(x =>  x.TransmittalNumber == transnumber).ToList();

            return Json(data);
        }
        public void FillCombo()
        {
            List<D_Project> ListProject = _context.projectManagerUW.Get().ToList();
            ViewBag.projectlist = ListProject;
        }

    }
}