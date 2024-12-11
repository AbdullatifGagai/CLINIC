using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ShiftApiController = ZCLINIC.Areas.Master.APIControllers.ShiftController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class ShiftController : Controller
    {
        public IActionResult Index()
        {
            return View(new ShiftApiController().ShiftGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Shift
        public IActionResult AShift(int id = 0)
        {
            return View(new ShiftApiController().ShiftGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveShift(Shift model)
        {
            return new ShiftApiController().ShiftSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateShift(Shift model)
        {
            return new ShiftApiController().ShiftUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteShift(int id)
        {
            return new ShiftApiController().ShiftDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}