using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReceiptPanelDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.ReceiptPanelDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReceiptPanelDetailController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View(new ReceiptPanelDetailApiController().ReceiptPanelDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        //}

        // create/edit view for ReceiptPanelDetail
        public IActionResult AReceiptPanelDetail(int id = 0)
        {
            return View(new ReceiptPanelDetailApiController().ReceiptPanelDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveReceiptPanelDetail(ReceiptPanelDetail model)
        {
            return new ReceiptPanelDetailApiController().ReceiptPanelDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateReceiptPanelDetail(ReceiptPanelDetail model)
        {
            return new ReceiptPanelDetailApiController().ReceiptPanelDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteReceiptPanelDetail(int id)
        {
            return new ReceiptPanelDetailApiController().ReceiptPanelDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
        [HttpGet]
        public List<ReceiptPanelDetail> ReceiptPanelDetailGetById(int id)
        {
            return new ReceiptPanelDetail().Transaction_ReceiptPanelDetailGetAll(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
    
    
    
    
    
    
    
    
    
    
    
    }
}