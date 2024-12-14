using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DoctorApiController = ZCLINIC.Areas.Master.APIControllers.DoctorController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View(new DoctorApiController().DoctorGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Doctor
        public IActionResult ADoctor(int id = 0)
        {
            return View(new DoctorApiController().DoctorGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDoctor(Doctor model)
        {
            return new DoctorApiController().DoctorSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateDoctor(Doctor model)
        {
            return new DoctorApiController().DoctorUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteDoctor(int id)
        {
            return new DoctorApiController().DoctorDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}