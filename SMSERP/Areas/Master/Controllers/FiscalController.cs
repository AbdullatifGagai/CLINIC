using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FiscalApiController = ZCLINIC.Areas.Master.APIControllers.FiscalController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class FiscalController : Controller
    {
        public IActionResult Index()
        {
            return View(new FiscalApiController().FiscalGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Fiscal
        public IActionResult AFiscal(int id = 0)
        {
            return View(new FiscalApiController().FiscalGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveFiscal(Fiscal model)
        {
            return new FiscalApiController().FiscalSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateFiscal(Fiscal model)
        {
            return new FiscalApiController().FiscalUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteFiscal(int id)
        {
            return new FiscalApiController().FiscalDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}