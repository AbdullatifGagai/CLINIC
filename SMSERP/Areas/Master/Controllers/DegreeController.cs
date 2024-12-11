using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DegreeApiController = ZCLINIC.Areas.Master.APIControllers.DegreeController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class DegreeController : Controller
    {
        public IActionResult Index()
        {
            return View(new DegreeApiController().DegreeGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for Degree
        public IActionResult ADegree(int id = 0)
        {
            return View(new DegreeApiController().DegreeGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveDegree(Degree model)
        {
            return new DegreeApiController().DegreeSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateDegree(Degree model)
        {
            return new DegreeApiController().DegreeUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteDegree(int id)
        {
            return new DegreeApiController().DegreeDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
    }
}