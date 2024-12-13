using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using salesDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.salesDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class salesDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // create/edit view for salesDetail
        public IActionResult AsalesDetail(int id = 0)
        {
            return View();
        }

        [HttpPost]
        public string SavesalesDetail(salesDetail model)
        {
            return new salesDetailApiController().salesDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdatesalesDetail(salesDetail model)
        {
            return new salesDetailApiController().salesDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeletesalesDetail(int id)
        {
            return new salesDetailApiController().salesDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        [HttpGet]
        public List<salesDetail> salesDetailDetailGetById(int id = 0)
        {
            return new salesDetail().Transaction_salesDetailGetById(id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        


    }
}