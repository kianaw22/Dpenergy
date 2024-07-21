using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities.Personel;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels.Personel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers.BasicInf
{
    [Area("PersonelArea")]
    [Authorize]
    public class PersonelStatusController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public PersonelStatusController(IUnitOfWork uow, IMapper mapper)
        {
            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var model = _context.PersonelStatusUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddPersonelStatus()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPersonelStatus(P_PersonelStatusViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.PersonelStatusUW.Create(_mapper.Map<P_PersonelStatus>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
       
        [HttpGet]
        public IActionResult DeletePersonelStatus(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var wp = _context.PersonelStatusUW.GetById(Id);
            if (wp == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deletePersonelStatus", wp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePersonelStatusPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.PersonelStatusUW.DeleteById(Id);
            _context.save();
            return RedirectToAction("Index");

        }
    }
}