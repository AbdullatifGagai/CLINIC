using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ReportDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.ReportDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class ReportDetailController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View(new ReportDetailApiController().ReportDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        //}

        // create/edit view for ReportDetail
        public IActionResult AReportDetail(int id = 0)
        {
            return View(new ReportDetailApiController().ReportDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveReportDetail(ReportDetail model)
        {
            return new ReportDetailApiController().ReportDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateReportDetail(ReportDetail model)
        {
            return new ReportDetailApiController().ReportDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteReportDetail(int id)
        {
            return new ReportDetailApiController().ReportDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
        [HttpGet]
        public List<ReportDetail> Transaction_ReportDetailGetAll(int id)
        {
            return new ReportDetail().Transaction_ReportDetailGetAll(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}