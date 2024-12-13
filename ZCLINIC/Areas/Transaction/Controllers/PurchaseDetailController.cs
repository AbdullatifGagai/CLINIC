using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PurchaseDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.PurchaseDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class PurchaseDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new PurchaseDetailApiController().PurchaseDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for PurchaseDetail
        public IActionResult APurchaseDetail(int id = 0)
        {
            return View();
        }

        [HttpPost]
        public string SavePurchaseDetail(PurchaseDetail model)
        {
            return new PurchaseDetailApiController().PurchaseDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdatePurchaseDetail(PurchaseDetail model)
        {
            return new PurchaseDetailApiController().PurchaseDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeletePurchaseDetail(int id)
        {
            return new PurchaseDetailApiController().PurchaseDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }



        public List<PurchaseDetail> PurchaseDetailGetById(int id = 0)
        {
            return (new PurchaseDetail().Transaction_PurchaseDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }











    }
}