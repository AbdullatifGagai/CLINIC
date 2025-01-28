using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MorphologyApiController = ZCLINIC.Areas.Master.APIControllers.MorphologyController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class MorphologyController : Controller
    {
        public IActionResult Index()
        {
            return View(new MorphologyApiController().MorphologyGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Morphology
        public IActionResult AMorphology(int id = 0)
        {
            return View(new MorphologyApiController().MorphologyGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveMorphology(Morphology model)
        {
            return new MorphologyApiController().MorphologySave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateMorphology(Morphology model)
        {
            return new MorphologyApiController().MorphologyUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteMorphology(int id)
        {
            return new MorphologyApiController().MorphologyDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}