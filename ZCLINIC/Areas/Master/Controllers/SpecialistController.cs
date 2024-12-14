using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SpecialistApiController = ZCLINIC.Areas.Master.APIControllers.SpecialistController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class SpecialistController : Controller
    {
        public IActionResult Index()
        {
            return View(new SpecialistApiController().SpecialistGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Specialist
        public IActionResult ASpecialist(int id = 0)
        {
            return View(new SpecialistApiController().SpecialistGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveSpecialist(Specialist model)
        {
            return new SpecialistApiController().SpecialistSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateSpecialist(Specialist model)
        {
            return new SpecialistApiController().SpecialistUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteSpecialist(int id)
        {
            return new SpecialistApiController().SpecialistDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}