using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using salesApiController = ZCLINIC.Areas.Transaction.APIControllers.salesController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class salesController : Controller
    {
        public IActionResult Index()
        {
            return View(new salesApiController().salesGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for sales
        public IActionResult Asales(int id = 0)
        {
            return View(new salesApiController().salesGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }
       

        [HttpPost]
        public string Savesales(sales sales, List<salesDetail> salesDetail)
        {
            return new sales().Transaction_salesSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), sales, salesDetail);
        }

        [HttpPost]
        public string Updatesales(sales sales, List<salesDetail> salesDetail)
        {
            return new sales().Transaction_salesUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), sales, salesDetail);
        }

        [HttpPost]
        public string Deletesales(int id)
        {
            return new salesApiController().salesDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

       






    }
}