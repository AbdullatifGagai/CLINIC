using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DayEndApiController = ZCLINIC.Areas.Master.APIControllers.DayEndController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class DayEndController : Controller
    {
        public IActionResult Index()
        {
            return View(new DayEndApiController().DayEndGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for DayEnd
        public IActionResult ADayEnd(int id = 0)
        {
            return View(new DayEndApiController().DayEndGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDayEnd(DayEnd model)
        {
            return new DayEndApiController().DayEndSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateDayEnd(DayEnd model)
        {
            return new DayEndApiController().DayEndUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteDayEnd(int id)
        {
            return new DayEndApiController().DayEndDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}