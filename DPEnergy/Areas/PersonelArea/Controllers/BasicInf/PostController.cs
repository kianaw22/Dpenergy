using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DPEnergy.DataModelLayer.Entities;
using DPEnergy.DataModelLayer.Services;
using DPEnergy.DataModelLayer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DPEnergy.Areas.PersonelArea.Controllers.BasicInf
{
   
    [Area("PersonelArea")]
    [Authorize]
    public class PostController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IMapper _mapper;
        public PostController(IUnitOfWork uow, IMapper mapper)
        {

            _context = uow;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            
            var model = _context.PostManagerUW.Get();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddPost()
        {
            FillCombo();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPost(P_PostViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                _context.PostManagerUW.Create(_mapper.Map<P_Post>(model));
                _context.save();

                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EditPost(String Id)
        {
            FillCombo();
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var post = _context.PostManagerUW.GetById(Id);
            var mappost = _mapper.Map<P_PostViewModel > (post);
            return View(mappost);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPost(P_PostViewModel model)
        {
            FillCombo();
            if (ModelState.IsValid)
            {
                var postmapper = _mapper.Map<P_Post>(model);
                _context.PostManagerUW.Update(postmapper);
                _context.save();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DeletePost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            var post = _context.PostManagerUW.GetById(Id);
            if (post == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            return PartialView("_deletePost", post);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePostPost(string Id)
        {
            if (Id == null)
            {
                return RedirectToAction("ErrorView", "Home");
            }
            _context.PostManagerUW.DeleteById(Id);
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