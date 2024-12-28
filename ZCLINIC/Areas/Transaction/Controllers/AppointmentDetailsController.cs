using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AppointmentDetailsApiController = ZCLINIC.Areas.Transaction.APIControllers.AppointmentDetailsController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class AppointmentDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View(new AppointmentDetailsApiController().AppointmentDetailsGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for AppointmentDetails
        public IActionResult AAppointmentDetails(int id = 0)
        {
            return View(new AppointmentDetailsApiController().AppointmentDetailsGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveAppointmentDetails(AppointmentDetails model)
        {
            return new AppointmentDetailsApiController().AppointmentDetailsSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateAppointmentDetails(AppointmentDetails model)
        {
            return new AppointmentDetailsApiController().AppointmentDetailsUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteAppointmentDetails(int id)
        {
            return new AppointmentDetailsApiController().AppointmentDetailsDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}