using ZCLINIC.Areas.Transaction.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlanMasterApiController = ZCLINIC.Areas.Transaction.APIControllers.PlanMasterController;

namespace ZCLINIC.Areas.Transaction.Controllers
{
    [Area("Transaction")]
    public class PlanMasterController : Controller
    {
        public IActionResult Index()
        {
            return View(new PlanMasterApiController().PlanMasterGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for PlanMaster
        public IActionResult APlanMaster(int id = 0)
        {
            return View(new PlanMasterApiController().PlanMasterGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SavePlanMaster(PlanMaster PlanMaster, List<PlanDetail> PlanDetail)
        {
            return new PlanMaster().Transaction_PlanMasterSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), PlanMaster, PlanDetail);
        }

        [HttpPost]
        public string UpdatePlanMaster(PlanMaster PlanMaster, List<PlanDetail> PlanDetail)
        {
            return new PlanMaster().Transaction_PlanMasterUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(), PlanMaster, PlanDetail);
        }

        [HttpPost]
        public string DeletePlanMaster(int id)
        {
            return new PlanMasterApiController().PlanMasterDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}