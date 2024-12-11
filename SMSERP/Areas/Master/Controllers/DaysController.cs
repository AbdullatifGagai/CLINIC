using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DaysApiController = ZCLINIC.Areas.Master.APIControllers.DaysController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class DaysController : Controller
    {
        public IActionResult Index()
        {
            return View(new DaysApiController().DaysGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Days
        public IActionResult ADays(int id = 0)
        {
            return View(new DaysApiController().DaysGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDays(Days model)
        {
            return new DaysApiController().DaysSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateDays(Days model)
        {
            return new DaysApiController().DaysUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteDays(int id)
        {
            return new DaysApiController().DaysDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}