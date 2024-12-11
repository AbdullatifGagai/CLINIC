using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlanDetailApiController = ZCLINIC.Areas.Transaction.APIControllers.PlanDetailController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class PlanDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new PlanDetailApiController().PlanDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for PlanDetail
        public IActionResult APlanDetail(int id = 0)
        {
            return View(new PlanDetailApiController().PlanDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SavePlanDetail(PlanDetail model)
        {
            return new PlanDetailApiController().PlanDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdatePlanDetail(PlanDetail model)
        {
            return new PlanDetailApiController().PlanDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeletePlanDetail(int id)
        {
            return new PlanDetailApiController().PlanDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
        [HttpGet]
        public List<PlanDetail> GetPlanDetail(int id)
        {
            return new PlanDetail().Transaction_PlanDetailGetId(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
     [HttpGet]
        public List<PlanDetail> GetSemesterMonth(int Id)
        {
            return new PlanDetail().GetSemesterMonth(Id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    
    
    
    
    
    }
}