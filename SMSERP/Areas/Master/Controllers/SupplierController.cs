using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SupplierApiController = ZCLINIC.Areas.Master.APIControllers.SupplierController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View(new SupplierApiController().SupplierGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Supplier
        public IActionResult ASupplier(int id = 0)
        {
            return View(new SupplierApiController().SupplierGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveSupplier(Supplier model)
        {
            return new SupplierApiController().SupplierSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateSupplier(Supplier model)
        {
            return new SupplierApiController().SupplierUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteSupplier(int id)
        {
            return new SupplierApiController().SupplierDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}