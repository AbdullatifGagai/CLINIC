using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PushNotiApiController = ZCLINIC.Areas.Transaction.APIControllers.PushNotiController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class PushNotiController : Controller
    {
        public IActionResult Index()
        {
            return View(new PushNotiApiController().PushNotiGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for PushNoti
        public IActionResult APushNoti(int id = 0)
        {
            return View(new PushNotiApiController().PushNotiGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SavePushNoti(PushNoti model)
        {
            return new PushNotiApiController().PushNotiSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdatePushNoti(PushNoti model)
        {
            return new PushNotiApiController().PushNotiUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeletePushNoti(int id)
        {
            return new PushNotiApiController().PushNotiDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}