using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PanelRateApiController = ZCLINIC.Areas.Master.APIControllers.PanelRateController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class PanelRateController : Controller
    {
        public IActionResult Index()
        {
            return View(new PanelRateApiController().PanelRateGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for PanelRate
        public IActionResult APanelRate(int id = 0)
        {
            return View(new PanelRateApiController().PanelRateGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SavePanelRate(PanelRate model)
        {
            return new PanelRateApiController().PanelRateSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdatePanelRate(PanelRate model)
        {
            return new PanelRateApiController().PanelRateUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeletePanelRate(int PId,int SerId)
        {
            return new PanelRate().Master_PanelRateDelete(PId, SerId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpGet]
        public List<PanelRate> GetAllPanelRate(int  Id)
        {
            return (new PanelRate().GetAllPanelRate(Id,HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }



    }
}