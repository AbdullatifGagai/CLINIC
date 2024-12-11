using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UnitApiController = ZCLINIC.Areas.Master.APIControllers.UnitController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class UnitController : Controller
    {
        public IActionResult Index()
        {
            return View(new UnitApiController().UnitGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Unit
        public IActionResult AUnit(int id = 0)
        {
            return View(new UnitApiController().UnitGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveUnit(Unit model)
        {
            return new UnitApiController().UnitSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateUnit(Unit model)
        {
            return new UnitApiController().UnitUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteUnit(int id)
        {
            return new UnitApiController().UnitDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}