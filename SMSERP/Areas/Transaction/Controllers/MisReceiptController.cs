using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MisReceiptApiController = ZCLINIC.Areas.Transaction.APIControllers.MisReceiptController;
using System.Linq;
using System;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class MisReceiptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexUKIT()
        {
            return View();
        }

        
        
        
        
        // create/edit view for MisReceipt
        public IActionResult AMisReceipt(int id = 0)
        {
            return View(new MisReceiptApiController().MisReceiptGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        public IActionResult AMisReceiptUKIT(int id = 0)
        {
            return View(new MisReceiptApiController().MisReceiptGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }




        [HttpPost]
        public string SaveMisReceipt(MisReceipt model)
        {
            return new MisReceiptApiController().MisReceiptSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateMisReceipt(MisReceipt model)
        {
            return new MisReceiptApiController().MisReceiptUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteMisReceipt(int id)
        {
            return new MisReceiptApiController().MisReceiptDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        public JsonResult Transaction_MisReceiptGetAll()
        {

            List<MisReceipt> data = new MisReceipt().Transaction_MisReceiptGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Convert.ToInt32(Request.Form["length"]), Convert.ToInt32(Request.Form["start"]), Request.Form["search[value]"].ToString(), Convert.ToInt32(Request.Form["Status"]));
            var a = data.FirstOrDefault();
            int TotalRecords = a != null ? a.TotalCount : 0;
            return Json(new { data, recordsFiltered = TotalRecords, recordsTotal = data.Count, draw = Convert.ToInt32(Request.Form["draw"]) });
        }







        [HttpGet]
        public List<MisReceipt> GetMisReceiptInfo(int  Id)
        {
            return new MisReceipt().GetMisReceiptInfoId(Id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }





    }
}