using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Master_ClinicServicesApiController = ZCLINIC.Areas.Master.APIControllers.Master_ClinicServicesController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class Master_ClinicServicesController : Controller
    {
        public IActionResult Index()
        {
            return View(new Master_ClinicServicesApiController().Master_ClinicServicesGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Master_ClinicServices
        public IActionResult AMaster_ClinicServices(int id = 0)
        {
            return View(new Master_ClinicServicesApiController().Master_ClinicServicesGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveMaster_ClinicServices(Master_ClinicServices model)
        {
            return new Master_ClinicServicesApiController().Master_ClinicServicesSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateMaster_ClinicServices(Master_ClinicServices model)
        {
            return new Master_ClinicServicesApiController().Master_ClinicServicesUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteMaster_ClinicServices(int id)
        {
            return new Master_ClinicServicesApiController().Master_ClinicServicesDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}