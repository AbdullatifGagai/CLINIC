using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LabDeparmentApiController = ZCLINIC.Areas.Master.APIControllers.LabDeparmentController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class LabDeparmentController : Controller
    {
        public IActionResult Index()
        {
            return View(new LabDeparmentApiController().LabDeparmentGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for LabDeparment
        public IActionResult ALabDeparment(int id = 0)
        {
            return View(new LabDeparmentApiController().LabDeparmentGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveLabDeparment(LabDeparment model)
        {
            return new LabDeparmentApiController().LabDeparmentSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateLabDeparment(LabDeparment model)
        {
            return new LabDeparmentApiController().LabDeparmentUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteLabDeparment(int id)
        {
            return new LabDeparmentApiController().LabDeparmentDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}