using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Transaction_Unit_transferApiController = ZCLINIC.Areas.Transaction.APIControllers.Transaction_Unit_transferController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class Transaction_Unit_transferController : Controller
    {
        public IActionResult Index()
        {
            return View(new Transaction_Unit_transferApiController().Transaction_Unit_transferGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Transaction_Unit_transfer
        public IActionResult ATransaction_Unit_transfer(int id = 0)
        {
            return View(new Transaction_Unit_transferApiController().Transaction_Unit_transferGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveTransaction_Unit_transfer(Transaction_Unit_transfer model)
        {
            return new Transaction_Unit_transferApiController().Transaction_Unit_transferSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateTransaction_Unit_transfer(Transaction_Unit_transfer model)
        {
            return new Transaction_Unit_transferApiController().Transaction_Unit_transferUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteTransaction_Unit_transfer(int id)
        {
            return new Transaction_Unit_transferApiController().Transaction_Unit_transferDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}