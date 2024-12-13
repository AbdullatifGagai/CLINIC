using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PurchaseApiController = ZCLINIC.Areas.Transaction.APIControllers.PurchaseController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View(new PurchaseApiController().PurchaseGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Purchase
        public IActionResult APurchase(int id = 0)
        {
            return View(new PurchaseApiController().PurchaseGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SavePurchase(Purchase Purchase, List<PurchaseDetail> purchaseDetail)
        {
            return new Purchase().Transaction_PurchaseSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Purchase, purchaseDetail);
        }

        [HttpPost]
        public string UpdatePurchase(Purchase Purchase, List<PurchaseDetail> purchaseDetail)
        {
            return new Purchase().Transaction_PurchaseUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), Purchase, purchaseDetail);
        }

        [HttpPost]
        public string DeletePurchase(int id)
        {
            return new PurchaseApiController().PurchaseDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}