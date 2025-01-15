using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LabtestDetailApiController = ZCLINIC.Areas.Master.APIControllers.LabtestDetailController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class LabtestDetailController : Controller
    {
        public IActionResult Index()
        {
            return View(new LabtestDetailApiController().LabtestDetailGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for LabtestDetail
        public IActionResult ALabtestDetail(int id = 0)
        {
            return View(new LabtestDetailApiController().LabtestDetailGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveLabtestDetail(LabtestDetail model)
        {
            return new LabtestDetailApiController().LabtestDetailSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateLabtestDetail(LabtestDetail model)
        {
            return new LabtestDetailApiController().LabtestDetailUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteLabtestDetail(int id)
        {
            return new LabtestDetailApiController().LabtestDetailDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}