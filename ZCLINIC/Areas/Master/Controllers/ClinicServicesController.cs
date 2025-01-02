using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ClinicServicesApiController = ZCLINIC.Areas.Master.APIControllers.ClinicServicesController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class ClinicServicesController : Controller
    {
        public IActionResult Index()
        {
            return View(new ClinicServicesApiController().ClinicServicesGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for ClinicServices
        public IActionResult AClinicServices(int id = 0)
        {
            return View(new ClinicServicesApiController().ClinicServicesGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveClinicServices(ClinicServices model)
        {
            return new ClinicServicesApiController().ClinicServicesSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateClinicServices(ClinicServices model)
        {
            return new ClinicServicesApiController().ClinicServicesUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteClinicServices(int id)
        {
            return new ClinicServicesApiController().ClinicServicesDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
        [HttpGet]
        public List<ClinicServices> Master_ClinicServicesGetServicesName(int Id)
        {
            return new ClinicServices().Master_ClinicServicesGetServicesName(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
      [HttpGet]
        public List<ClinicServices> Master_ClinicServicesGetIdServices(int Id)
        {
            return new ClinicServices().Master_ClinicServicesGetIdServices(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
    
    
    
    
    
    
    
    }
}