using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReceiptApiController = ZCLINIC.Areas.Transaction.APIControllers.ReceiptController;
using System.Linq;
using System;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReceiptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // create/edit view for Receipt
        public IActionResult AReceipt(int id = 0)
        {
             return View(new ReceiptApiController().ReceiptGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveReceipt(Receipt model)
        {
            return new ReceiptApiController().ReceiptSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateReceipt(Receipt model)
        {
            return new ReceiptApiController().ReceiptUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteReceipt(int id)
        {
            return new ReceiptApiController().ReceiptDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

           [HttpGet]
        public List<Receipt> Transaction_ReceiptGetAllAdmission(int id)
        {
            return new Receipt().Transaction_ReceiptGetAllAdmission(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
        [HttpGet]
         public List<Receipt> Transaction_ReceiptGetReceiptId(int id)
        {
            return new Receipt().Transaction_ReceiptGetReceiptId(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




        public IActionResult A_AdmissionReceipt(int id = 0)
        {
            return View(new Receipt().Transaction_ReceiptAdmissionGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }



        public IActionResult AdmissionReceipt(int id = 0)
        {
            return View(new Receipt().Transaction_AdmissionGrIdGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }



        public JsonResult Transaction_ReceiptGetAll()
        {

            List<Receipt> data = new Receipt().Transaction_ReceiptGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }





    }
}