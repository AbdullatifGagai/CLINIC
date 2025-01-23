using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReportMasterApiController = ZCLINIC.Areas.Transaction.APIControllers.ReportMasterController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReportMasterController : Controller
    {
        public IActionResult Index()
        {
            return View(new ReportMasterApiController().ReportMasterGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for ReportMaster
        public IActionResult AReportMaster(int id = 0)
        {
            return View(new ReportMasterApiController().ReportMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveReportMaster(ReportMaster ReportMaster,List<ReportDetail> ReportDetail)
        {
            return new ReportMaster().Transaction_ReportMasterSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(),ReportMaster,ReportDetail);
        }

        [HttpPost]
        public string UpdateReportMaster(ReportMaster ReportMaster, List<ReportDetail> ReportDetail)
        {
         
            return new ReportMaster().Transaction_ReportMasterUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), ReportMaster, ReportDetail);
        }

        [HttpPost]
        public string DeleteReportMaster(int id)
        {
            return new ReportMasterApiController().ReportMasterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}