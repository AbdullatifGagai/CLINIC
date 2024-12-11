using ZCLINIC.Areas.Master.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AcadmicYearApiController = ZCLINIC.Areas.Master.APIControllers.AcadmicYearController;

namespace ZCLINIC.Areas.Master.Controllers
{
    [Area("Master")]
    public class AcadmicYearController : Controller
    {
        public IActionResult Index()
        {
            return View(new AcadmicYearApiController().AcadmicYearGetAll(HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        // create/edit view for AcadmicYear
        public IActionResult AAcadmicYear(int id = 0)
        {
            return View(new AcadmicYearApiController().AcadmicYearGetById(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo()));
        }

        [HttpPost]
        public string SaveAcadmicYear(AcadmicYear model)
        {
            return new AcadmicYearApiController().AcadmicYearSave(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string UpdateAcadmicYear(AcadmicYear model)
        {
            return new AcadmicYearApiController().AcadmicYearUpdate(new List<object>() { model, HttpContext.Session.GetBValues() }, HttpContext.GetIP(), HttpContext.GetCInfo());
        }

        [HttpPost]
        public string DeleteAcadmicYear(int id)
        {
            return new AcadmicYearApiController().AcadmicYearDelete(id, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
   
        [HttpGet]
        public List<AcadmicYear> Master_AcadmicYearSessionGetAll(int SId)
        {
            return new AcadmicYear().Master_AcadmicYearSessionGetAll(SId, HttpContext.Session.GetBValues(), HttpContext.GetIP(), HttpContext.GetCInfo());
        }
   
    
    
    
    
    
    
    
    
    
    }
}