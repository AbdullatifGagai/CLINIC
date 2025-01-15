using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LabtestApiController = ZCLINIC.Areas.Master.APIControllers.LabtestController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class LabtestController : Controller
    {
        public IActionResult Index()
        {
            return View(new LabtestApiController().LabtestGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Labtest
        public IActionResult ALabtest(int id = 0)
        {
            return View(new LabtestApiController().LabtestGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveLabtest(Labtest Labtest,List<LabtestDetail> LabtestDetail)
        {
            return new Labtest().Master_LabtestSave(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(),Labtest,LabtestDetail);
        }

        [HttpPost]
        public string UpdateLabtest(Labtest Labtest, LabtestDetail LabtestDetail)
        {
            return new Labtest().Master_LabtestUpdate(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo(),Labtest,LabtestDetail);
        }

        [HttpPost]
        public string DeleteLabtest(int id)
        {
            return new LabtestApiController().LabtestDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}