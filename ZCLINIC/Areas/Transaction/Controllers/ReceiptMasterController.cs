using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReceiptMasterApiController = ZCLINIC.Areas.Transaction.APIControllers.ReceiptMasterController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReceiptMasterController : Controller
    {
        public IActionResult Index()
        {
            return View(new ReceiptMasterApiController().ReceiptMasterGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for ReceiptMaster
        public IActionResult AReceiptMaster(int id = 0)
        {
            return View(new ReceiptMasterApiController().ReceiptMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveReceiptMaster(ReceiptMaster model)
        {
            return new ReceiptMasterApiController().ReceiptMasterSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateReceiptMaster(ReceiptMaster model)
        {
            return new ReceiptMasterApiController().ReceiptMasterUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteReceiptMaster(int id)
        {
            return new ReceiptMasterApiController().ReceiptMasterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}