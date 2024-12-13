using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Transaction_ReceiptApiController = ZCLINIC.Areas.Transaction.APIControllers.Transaction_ReceiptController;
using System;
using System.Linq;
using System.Net;
using System.IO;
using ZCLINIC.Areas.Master.Models;
using System.Net.Mail;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class Transaction_ReceiptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // create/edit view for Transaction_Receipt
        public IActionResult ATransaction_Receipt(int id = 0)
        {
            return View(new Transaction_ReceiptApiController().Transaction_ReceiptGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveTransaction_Receipt(Transaction_Receipt model)
        {
            return new Transaction_ReceiptApiController().Transaction_ReceiptSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());




            // MessageBox.Show(Result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            
            
            
      
           // MessageBox.Show(Result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);








        }

        [HttpPost]
        public string UpdateTransaction_Receipt(Transaction_Receipt model)
        {
            return new Transaction_ReceiptApiController().Transaction_ReceiptUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteTransaction_Receipt(int id,int Refid)
        {
            return new Transaction_ReceiptApiController().Transaction_ReceiptDelete(id, Refid, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]

        public JsonResult Transaction_ReceiptGetAllWithPagination()
        {
            List<Transaction_Receipt> data = new Transaction_ReceiptApiController().Transaction_ReceiptGetAllWithPagination(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }






        public void SendSms(int AllowId, int RId,int cpdId,int ValdationId)
        {

          
            
            
            var AllowData = new Transaction_Receipt().Transaction_ReceiptSms(AllowId, RId, cpdId, ValdationId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());

            WebClient client = new WebClient();
            
            Stream s = client.OpenRead(AllowData.APIAdd);

            StreamReader reader = new StreamReader(s);
            string Result = reader.ReadToEnd();
        



        }
    }
}