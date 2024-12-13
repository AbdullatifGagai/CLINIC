using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ServicesApiController = ZCLINIC.Areas.Master.APIControllers.ServicesController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View(new ServicesApiController().ServicesGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Services
        public IActionResult AServices(int id = 0)
        {
            return View(new ServicesApiController().ServicesGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveServices(Services model)
        {
            return new ServicesApiController().ServicesSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateServices(Services model)
        {
            return new ServicesApiController().ServicesUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteServices(int id)
        {
            return new ServicesApiController().ServicesDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}