using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AppointmentApiController = ZCLINIC.Areas.Transaction.APIControllers.AppointmentController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View(new AppointmentApiController().AppointmentGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Appointment
        public IActionResult AAppointment(int id = 0)
        {
            return View(new AppointmentApiController().AppointmentGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveAppointment(Appointment model)
        {
            return new AppointmentApiController().AppointmentSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateAppointment(Appointment model)
        {
            return new AppointmentApiController().AppointmentUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteAppointment(int id)
        {
            return new AppointmentApiController().AppointmentDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}