using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Master_DeparmentApiController = ZCLINIC.Areas.Master.APIControllers.Master_DeparmentController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class Master_DeparmentController : Controller
    {
        public IActionResult Index()
        {
            return View(new Master_DeparmentApiController().Master_DeparmentGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Master_Deparment
        public IActionResult AMaster_Deparment(int id = 0)
        {
            return View(new Master_DeparmentApiController().Master_DeparmentGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveMaster_Deparment(Master_Deparment model)
        {
            return new Master_DeparmentApiController().Master_DeparmentSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateMaster_Deparment(Master_Deparment model)
        {
            return new Master_DeparmentApiController().Master_DeparmentUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteMaster_Deparment(int id)
        {
            return new Master_DeparmentApiController().Master_DeparmentDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}