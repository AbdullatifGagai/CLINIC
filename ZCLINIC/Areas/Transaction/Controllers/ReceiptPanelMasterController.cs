using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReceiptPanelMasterApiController = ZCLINIC.Areas.Transaction.APIControllers.ReceiptPanelMasterController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReceiptPanelMasterController : Controller
    {
        public IActionResult Index()
        {
            return View(new ReceiptPanelMasterApiController().ReceiptPanelMasterGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for ReceiptPanelMaster
        public IActionResult AReceiptPanelMaster(int id = 0)
        {
            return View(new ReceiptPanelMasterApiController().ReceiptPanelMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveReceiptPanelMaster(ReceiptPanelMaster ReceiptPanelMaster, List<ReceiptPanelDetail> ReceiptPanelDetail)
        {
            return new ReceiptPanelMaster().Transaction_ReceiptPanelMasterSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(),ReceiptPanelMaster, ReceiptPanelDetail);
        }

        [HttpPost]
        public string UpdateReceiptPanelMaster(ReceiptPanelMaster ReceiptPanelMaster, List<ReceiptPanelDetail> ReceiptPanelDetail)
        {
            return new ReceiptPanelMaster().Transaction_ReceiptPanelMasterUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), ReceiptPanelMaster, ReceiptPanelDetail);
        }

        [HttpPost]
        public string DeleteReceiptPanelMaster(int id)
        {
            return new ReceiptPanelMasterApiController().ReceiptPanelMasterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}