using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StoreApiController = ZCLINIC.Areas.Master.APIControllers.StoreController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View(new StoreApiController().StoreGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Store
        public IActionResult AStore(int id = 0)
        {
            return View(new StoreApiController().StoreGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveStore(Store model)
        {
            return new StoreApiController().StoreSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateStore(Store model)
        {
            return new StoreApiController().StoreUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteStore(int id)
        {
            return new StoreApiController().StoreDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}