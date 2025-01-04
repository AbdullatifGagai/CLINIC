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
 
    
    
    
    
    
    }
}