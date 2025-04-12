using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DoctorLedgerMasterApiController = ZCLINIC.Areas.Transaction.APIControllers.DoctorLedgerMasterController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class DoctorLedgerMasterController : Controller
    {
        public IActionResult Index()
        {
            return View(new DoctorLedgerMasterApiController().DoctorLedgerMasterGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for DoctorLedgerMaster
        public IActionResult ADoctorLedgerMaster(int id = 0)
        {
            return View(new DoctorLedgerMasterApiController().DoctorLedgerMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDoctorLedgerMaster(DoctorLedgerMaster model)
        {
            return new DoctorLedgerMasterApiController().DoctorLedgerMasterSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateDoctorLedgerMaster(DoctorLedgerMaster model)
        {
            return new DoctorLedgerMasterApiController().DoctorLedgerMasterUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteDoctorLedgerMaster(int id)
        {
            return new DoctorLedgerMasterApiController().DoctorLedgerMasterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}