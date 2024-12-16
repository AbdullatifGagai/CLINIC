using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DoctorDayDatailsApiController = ZCLINIC.Areas.Master.APIControllers.DoctorDayDatailsController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class DoctorDayDatailsController : Controller
    {
        public IActionResult Index()
        {
            return View(new DoctorDayDatailsApiController().DoctorDayDatailsGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for DoctorDayDatails
        public IActionResult ADoctorDayDatails(int id = 0)
        {
            return View(new DoctorDayDatailsApiController().DoctorDayDatailsGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDoctorDayDatails(DoctorDayDatails model)
        {
            return new DoctorDayDatailsApiController().DoctorDayDatailsSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateDoctorDayDatails(DoctorDayDatails model)
        {
            return new DoctorDayDatailsApiController().DoctorDayDatailsUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteDoctorDayDatails(int id)
        {
            return new DoctorDayDatailsApiController().DoctorDayDatailsDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}