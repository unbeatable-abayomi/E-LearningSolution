using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ELearningWebApp.Models;
using ELearningWebApp.ServicesRepo;
using Microsoft.AspNetCore.Mvc;

namespace ELearningWebApp.Controllers
{
    public class ELearningController : Controller
    {

        private readonly IELearning _eLearning;


        public ELearningController(IELearning eLearning)
        {
            _eLearning = eLearning;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ELearningModel eLearning)
        {
            _eLearning.AddELearning(eLearning);
            return View(eLearning);
        }


        public IActionResult Lists()
        {
            return View(_eLearning.GetELearnings);
        }

        public IActionResult Details(long Id)
        {
            ELearningModel eLearningModel = _eLearning.GetELearning(Id);
            return View(eLearningModel);
        }

        [HttpGet]
        public IActionResult Delete(long Id)
        {
           ELearningModel eLearningModel = _eLearning.GetELearning(Id);
            if (eLearningModel == null)
            {
                //error message
                return RedirectToAction("Lists");
            }
            return View(eLearningModel);
        }

        [HttpPost]
        public IActionResult Deleted(long Id)
        {
            var eLearning = _eLearning.Delete(Id);
            //return View("DeleteMessage", eLearning);
            return RedirectToAction("Lists",eLearning);
        }


        [HttpGet]
        public IActionResult Edit(long Id)
        {
            ELearningModel eLearningModel = _eLearning.GetELearning(Id);

            return View(eLearningModel);
        }

        [HttpPost]
        public IActionResult Edit(ELearningModel eLearningModel)
        {
            _eLearning.EditELearning(eLearningModel);

            return View(eLearningModel);
        }

        [HttpPost]
        public IActionResult Search (string course)
        {
            IQueryable<ELearningModel> eLearningModels = _eLearning.Search(course);
            return View("SearchResult", eLearningModels);
        }

        [HttpGet]
        public IActionResult Search()
        {
            
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
