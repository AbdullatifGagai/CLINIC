using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReceiptMasterApiController = ZCLINIC.Areas.Transaction.APIControllers.ReceiptMasterController;
using System.Linq;
using System;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReceiptMasterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexR()
        {
            return View();
        }







        // create/edit view for ReceiptMaster
        public IActionResult AReceiptMaster(int id = 0)
        {
            return View(new ReceiptMasterApiController().ReceiptMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        public IActionResult AReceiptMasterRefund(int id = 0)
        {
            return View(new ReceiptMasterApiController().ReceiptMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }





        [HttpPost]
        public string SaveReceiptMaster(ReceiptMaster ReceiptMaster, List<ReceiptDetail> ReceiptDetail)
        {
            return new ReceiptMaster().Transaction_ReceiptMasterSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(),ReceiptMaster,ReceiptDetail);
        }

        [HttpPost]
        public string UpdateReceiptMaster(ReceiptMaster ReceiptMaster, List<ReceiptDetail> ReceiptDetail)
        {
            return new ReceiptMaster().Transaction_ReceiptMasterUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), ReceiptMaster, ReceiptDetail);
        }

        [HttpPost]
        public string DeleteReceiptMaster(int id)
        {
            return new ReceiptMasterApiController().ReceiptMasterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
 
        [HttpGet]
        public List<ReceiptMaster> Transaction_ReceiptMasterGetRefNO(string  id)
        {
            return new ReceiptMaster().Transaction_ReceiptMasterGetRefNO(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpGet]
        public List<ReceiptMaster> Transaction_ReceiptMasterGetRefund_RefNO(string  id)
        {
            return new ReceiptMaster().Transaction_ReceiptMasterGetRefund_RefNO(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }















           [HttpGet]
        public List<ReceiptMaster> ReceiptMasterGetLabReceiptId()
        {
            return new ReceiptMaster().ReceiptMasterGetLabReceiptId(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }




        public JsonResult Transaction_ReceiptGetAll()
        {

            List<ReceiptMaster> data = new ReceiptMaster().Transaction_ReceiptMasterGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }

          public JsonResult Transaction_ReceiptRefundGetAll()
         {

            List<ReceiptMaster> data = new ReceiptMaster().Transaction_ReceiptRefundGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }



    }
}