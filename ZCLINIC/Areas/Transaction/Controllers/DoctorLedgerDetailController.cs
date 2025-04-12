using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DoctorLedgerDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.DoctorLedgerDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class DoctorLedgerDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new DoctorLedgerDetailApiController().DoctorLedgerDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for DoctorLedgerDetail
        public IActionResult ADoctorLedgerDetail(int id = 0)
        {
            return View(new DoctorLedgerDetailApiController().DoctorLedgerDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDoctorLedgerDetail(DoctorLedgerDetail model)
        {
            return new DoctorLedgerDetailApiController().DoctorLedgerDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateDoctorLedgerDetail(DoctorLedgerDetail model)
        {
            return new DoctorLedgerDetailApiController().DoctorLedgerDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteDoctorLedgerDetail(int id)
        {
            return new DoctorLedgerDetailApiController().DoctorLedgerDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}