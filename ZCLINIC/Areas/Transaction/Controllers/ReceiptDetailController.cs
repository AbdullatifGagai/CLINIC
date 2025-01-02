using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReceiptDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.ReceiptDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReceiptDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new ReceiptDetailApiController().ReceiptDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for ReceiptDetail
        public IActionResult AReceiptDetail(int id = 0)
        {
            return View(new ReceiptDetailApiController().ReceiptDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveReceiptDetail(ReceiptDetail model)
        {
            return new ReceiptDetailApiController().ReceiptDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateReceiptDetail(ReceiptDetail model)
        {
            return new ReceiptDetailApiController().ReceiptDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteReceiptDetail(int id)
        {
            return new ReceiptDetailApiController().ReceiptDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}