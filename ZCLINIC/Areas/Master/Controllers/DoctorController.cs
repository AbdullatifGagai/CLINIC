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
            return View(new Doctor().Master_DoctorGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDoctor(Doctor Doctor, List<DoctorDayDatails> DoctorDayDatails)
        {
            return new Doctor().Master_DoctorSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Doctor, DoctorDayDatails);
        }

        [HttpPost]
        public string UpdateDoctor(Doctor Doctor, List<DoctorDayDatails> DoctorDayDatails)
        {
            return new Doctor().Master_DoctorUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Doctor, DoctorDayDatails);
        }

        [HttpPost]
        public string DeleteDoctor(int id)
        {
            return new DoctorApiController().DoctorDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpGet]
        public List<Doctor> Master_DoctorInfo(int Id)
        {
            return new Doctor().Master_DoctorInfo(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




    }
}