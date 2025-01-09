using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AppointmentApiController = ZCLINIC.Areas.Transaction.APIControllers.AppointmentController;
using System.Linq;
using System;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
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


        public IActionResult AAppointmentReceiptId(int id = 0)
        {
            return View(new Appointment().Transaction_AppointmentGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }






        [HttpPost]
        public string UpdateGetReceiptId(Appointment model)
        {
            return new AppointmentApiController().UpdateGetReceiptId(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }







        public JsonResult Transaction_AppointmentGetAll()
        {

            List<Appointment> data = new Appointment().Transaction_AppointmentGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }



    }
}